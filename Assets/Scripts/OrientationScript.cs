using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationScript : MonoBehaviour
{

    public bool allowVertical;
    public GameObject menuHorizontal;

    public GameObject menuVertical;

    public GameObject logoVertical;
    // Start is called before the first frame update
    

    void Start(){
        if(!allowVertical){
            Screen.autorotateToPortrait = false;
            menuVertical.SetActive(false);
            menuHorizontal.SetActive(true);
            logoVertical.SetActive(false);
        }
        else{
            Screen.autorotateToPortrait = true;
            menuHorizontal.SetActive(false);
            menuVertical.SetActive(true);
            logoVertical.SetActive(true);
        }
    }
    void FixedUpdate(){
        if(allowVertical){
            if(Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight){
            menuHorizontal.SetActive(true);
            menuVertical.SetActive(false);
            logoVertical.SetActive(false);
            } else if(Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown){
                menuHorizontal.SetActive(false);
                menuVertical.SetActive(true);
                logoVertical.SetActive(true);
            }
        }
    }

    // Update is called once per frame
}
