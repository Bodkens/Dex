using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class FlipTimer : Timer
{
    public Game instance;
    public Image imageOfTimer;
    
    public override void onRestart(){
        imageOfTimer.fillAmount = 0;
    }

    public override void onUpdate(){
        imageOfTimer.fillAmount = startTime / time;
        if(instance.colorMode){
            imageOfTimer.color = Color.white;
            imageOfTimer.sprite = instance.timerLibrary[1];
        }
        else{
            imageOfTimer.color = new Color(255, 129, 0);
            imageOfTimer.sprite = instance.timerLibrary[0]; 
        }
    }

    public override void onTick(){
        instance.FlipAll();
        CheckColorMode();
        RestartTimer();
    }
    public void CheckColorMode(){
        foreach (Player p in instance.playersList){ 
            if(p.trash.Count != 0){
                if(p.trash[p.trash.Count - 1].shape.name == "dex"){
                    instance.colorMode = true;
                    return;
                }
            }
        }
        instance.colorMode = false;
    }
}
