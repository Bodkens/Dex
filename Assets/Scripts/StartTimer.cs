using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartTimer : Timer {

    public GameObject pauseButton;

    public TMP_Text textOfTimer;

    public FlipTimer FlipTimer;

    public override void onUpdate() {
        textOfTimer.text = startTime.ToString("n0");
    }
    public override void onTick() {
        FlipTimer.timerEnabled = true;
        timerEnabled = false;
        GameObject.Find("StartTimerPanel").SetActive(false);
        pauseButton.SetActive(true);
        Game.gameStarted = true;
    }
    public override void onStart() {
        textOfTimer.text = time.ToString("n0");
    }



}
