using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
public class PauseButton : MonoBehaviour {
    public GameObject pausePanel;

    public GameObject alert;
    public GameObject pauseButton;

    public GameObject pauseBackground;

    public void Pause() {
        pauseBackground.SetActive(true);
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume() {
        pauseBackground.SetActive(false);
        pausePanel.SetActive(false);

        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }






}
