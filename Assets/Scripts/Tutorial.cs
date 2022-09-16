using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : Game {
    public Player player;
    public Tutor tutor;
    public GameObject log;

    public static bool next = true;
    public override void onStart() {
        Screen.autorotateToPortrait = true;
        Game.gameStarted = true;
        player.figures = new List<Figure>();
        tutor.figures = new List<Figure>();
        player.trash = new List<Figure>();
        tutor.trash = new List<Figure>();
        player.figures.Add(new Figure(Resources.Load<Sprite>("Figures/star"), Game.colorLibrary[0]));
        tutor.figures.Add(new Figure(Resources.Load<Sprite>("Figures/pentagon"), Game.colorLibrary[1]));
        player.Refresh();
        tutor.Refresh();
        log.GetComponent<TMP_Text>().text = "Welcome to Dex! Press a \"Next\" button to continue";
        playersList.Add(tutor);
        playersList.Add(player);
    }

    public void FixedUpdate() {

    }
}
