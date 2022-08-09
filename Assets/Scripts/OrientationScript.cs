using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationScript : MonoBehaviour {

    public bool allowVertical;
    public GameObject menuHorizontal;

    public GameObject menuVertical;

    void Start() {
        if (!allowVertical) {
            Screen.autorotateToPortrait = false;
            menuVertical.SetActive(false);
            menuHorizontal.SetActive(true);
        } else {
            Screen.autorotateToPortrait = true;
            menuHorizontal.SetActive(false);
            menuVertical.SetActive(true);
        }
    }
    void FixedUpdate() {
        if (allowVertical) {
            if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight) {
                menuHorizontal.SetActive(true);
                menuVertical.SetActive(false);
            } else if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown) {
                menuHorizontal.SetActive(false);
                menuVertical.SetActive(true);
            }
        }
    }
}
