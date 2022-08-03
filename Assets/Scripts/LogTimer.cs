using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LogTimer : Timer{
   
    public GameObject logText;
    public override void onTick(){
        this.logText.GetComponent<TMP_Text>().text = "";
        logText.SetActive(false);
        this.timerEnabled = false;
    }



    public void Log(string message){
        RestartTimer();
        this.logText.GetComponent<TMP_Text>().text += message + "\n";
        logText.SetActive(true);
        this.timerEnabled = true;
    }
    public void LogLine(string message){
        RestartTimer();
        this.logText.GetComponent<TMP_Text>().text += message;
        logText.SetActive(true);
        this.timerEnabled = true;
    }
   
}
