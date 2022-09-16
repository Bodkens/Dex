using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using TMPro;
public class TutorialSteps : MonoBehaviour {

    public static int step = 0;

    public GameObject log;
    public Tutor tutor;

    public GameObject backButton;
    public void NextStep() {
        step++;
        LoadStep(step);
    }

    public void PreviousStep() {
        if (step >= 2) {
            step--;
            LoadStep(step);
        }
    }
    private void LoadStep(int i) {
        if (i <= 1) {
            backButton.SetActive(false);
        } else if (i > 1) {
            backButton.SetActive(true);
        }
        switch (i) {
            case 1:
                log.GetComponent<TMP_Text>().text = "Dex! is a game based on dexterity. You need to pay attention on your oppent card's shape and color";
                break;
            case 2:
                log.GetComponent<TMP_Text>().text = "By default, each turn opponents compare their cards' shape. The first one who noticed that cards' shape are uqual, presses the rounded button. ";
                break;
            case 3:
                tutor.figures[0] = new Figure(Resources.Load<Sprite>("Figures/pentagon"), Game.colorLibrary[1]);
                tutor.Refresh();
                log.GetComponent<TMP_Text>().text = "The first one who pressed button gets rid of his trash. If player gets rid of of all his cards and trash, he wins";
                break;
            case 4:
                log.GetComponent<TMP_Text>().text = "If anyone of players has \"D\" card, the next turn players must check cards' color, not shape. If colors are equal, player who pressed button first gets rid of his trash. On the next turn players must check cards' shape again.";
                tutor.figures[0] = new Figure(Resources.Load<Sprite>("Figures/dex"), Color.white);
                tutor.Refresh();
                break;
            case 5:
                log.GetComponent<TMP_Text>().text = "Now, you passed tutorial. Good luck!";
                break;
            case 6:
                SceneManager.LoadScene("Singleplayer");
                break;
        }
    }
}
