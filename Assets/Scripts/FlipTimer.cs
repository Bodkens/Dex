using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class FlipTimer : Timer {
    public Game instance;
    public Image imageOfTimer;

    public override void onRestart() {
        imageOfTimer.fillAmount = 0;
    }

    public override void onUpdate() {
        imageOfTimer.fillAmount = startTime / time;
        if (Game.colorMode) {
            imageOfTimer.color = Color.white;
            imageOfTimer.sprite = Game.timerLibrary[1];
        } else {
            imageOfTimer.color = new Color(0, 255f / 255f, 245f / 255f);
            imageOfTimer.sprite = Game.timerLibrary[0];
        }
    }

    public override void onTick() {
        instance.FlipAll();
        CheckColorMode();
        RestartTimer();
    }
    public void CheckColorMode() {
        foreach (Player p in instance.playersList) {
            if (p.trash.Count != 0) {
                if (p.trash[p.trash.Count - 1].shape.name == "dex") {
                    Game.colorMode = true;
                    return;
                }
            }
        }
        Game.colorMode = false;
    }
}
