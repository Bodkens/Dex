using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject objectOfPlayer;

    public List<Figure> figures;

    public List<Figure> trash;

    public GameObject imageOfFigure;

    public GameObject textOfFigures;

    public GameObject textOfTrash;

    public string playerName;

    public Game instance;

    public FlipTimer timer;

    public LogTimer logTimer;


    public void Refresh() {

        if (this.figures.Count == 0 && this.trash.Count == 0) {
            instance.Win(this.playerName);
            return;
        }

        this.imageOfFigure.GetComponent<Image>().sprite = this.figures[0].shape;
        this.imageOfFigure.GetComponent<Image>().color = this.figures[0].color;
        this.textOfFigures.GetComponent<TMP_Text>().text = this.figures.Count.ToString();
        this.textOfTrash.GetComponent<TMP_Text>().text = this.trash.Count.ToString();

    }
    public void Create() {



        this.figures = new List<Figure>();
        this.trash = new List<Figure>();

        System.Random random = new System.Random();
        for (int i = 0; i < Game.cards; i++) {

            figures.Add(new Figure(Game.shapeLibrary[random.Next(0, Game.shapeLibrary.Length)], Game.colorLibrary[random.Next(0, Game.colorLibrary.Length)]));
            if (figures[i].shape.name == "dex") {
                figures[i].color = Color.white;
            }
        }
        Refresh();
    }

    public void Flip() {


        this.trash.Add(this.figures[0]);
        this.figures.Remove(figures[0]);
        if (this.figures.Count == 0) {

            this.figures.AddRange(MixList(this.trash));
            this.trash.Clear();
        }
        Refresh();
    }

    private bool Compare(Player player, bool colorMode) {
        if (!colorMode) {
            if (this.figures[0].shape == player.figures[0].shape) {
                return true;
            }
            return false;
        }
        if (this.figures[0].color == player.figures[0].color) {
            return true;
        }
        return false;
    }

    private List<Figure> MixList(List<Figure> list) {

        System.Random random = new System.Random();
        int n = list.Count;

        for (int i = list.Count - 1; i > 1; i--) {
            int rnd = random.Next(i + 1);
            Figure value = list[rnd];
            list[rnd] = list[i];
            list[i] = value;
        }
        List<Figure> newList = list;

        return newList;

    }


    public virtual void CompareAll() {

        instance.playersList.Remove(this);
        List<Player> compareList = new List<Player>();
        foreach (Player p in instance.playersList) {
            if (this.Compare(p, Game.colorMode)) {
                compareList.Add(p);
            }
        }
        if (compareList.Count > 0) {
            int part = trash.Count / compareList.Count;
            System.Random rnd = new System.Random();
            int index = rnd.Next(0, compareList.Count - 1);
            compareList[index].trash.Add(this.figures[0]);
            logTimer.Log(compareList[index].playerName + " gets top card");
            this.figures.RemoveAt(0);
            foreach (Player p in compareList) {
                for (int i = 0; i < part; i++) {
                    p.trash.Add(this.trash[0]);
                    this.trash.RemoveAt(0);
                }

                logTimer.Log(p.playerName + " gets " + part + " cards from trash");
            }

            if (this.trash.Count != 0) {
                int _index = rnd.Next(0, compareList.Count - 1);
                compareList[index].trash.AddRange(this.trash);
                logTimer.Log(compareList[index].playerName + " gets " + this.trash.Count + " cards from trash");
            }

            instance.FlipAll();
            timer.RestartTimer();

        } else {
            if (this.figures.Count + this.trash.Count + 10 <= 199) {
                System.Random rnd = new System.Random();
                List<Figure> newFigs = new List<Figure>();
                logTimer.Log(this.playerName + " mistaken and gets 10 cards!");
                for (int i = 0; i < 10; i++) {
                    newFigs.Add(new Figure(Game.shapeLibrary[rnd.Next(0, Game.shapeLibrary.Length)], Game.colorLibrary[rnd.Next(0, Game.colorLibrary.Length)]));
                    if (newFigs[i].shape.name == "dex") {
                        newFigs[i].color = Color.white;
                    }
                }
                this.figures.AddRange(newFigs);
            } else {
                logTimer.Log(this.playerName + " mistaken but has too much cards for penalty!");
            }

        }

        instance.playersList.Add(this);
        instance.RefreshAll();
        compareList.Clear();



    }








}