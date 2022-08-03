using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationScript : MonoBehaviour
{

    public bool allowVertical;
    public GameObject canvasHorizontal;

    public GameObject canvasVertical;
    // Start is called before the first frame update
    

    void Start(){
        if(!allowVertical){
            Screen.autorotateToPortrait = false;
            canvasVertical.SetActive(false);
            canvasHorizontal.SetActive(true);
        }
        else{
            Screen.autorotateToPortrait = true;
            canvasHorizontal.SetActive(false);
            canvasVertical.SetActive(true);
        }
    }
    void FixedUpdate(){
        if(allowVertical){
            if(Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight){
            canvasHorizontal.SetActive(true);
            canvasVertical.SetActive(false);
            } else if(Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown){
                canvasHorizontal.SetActive(false);
                canvasVertical.SetActive(true);
            }
        }
    }

    // Update is called once per frame
}
