using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertButton : MonoBehaviour {

    public GameObject alert;

    public GameObject pause;

    public void Yes() {
        Time.timeScale = 1;
    }
    public void No() {
        alert.SetActive(false);
        pause.SetActive(true);
    }

    public void Exit() {
        alert.SetActive(true);
        pause.SetActive(false);
    }





}
