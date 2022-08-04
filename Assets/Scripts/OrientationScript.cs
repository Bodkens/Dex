using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationScript : MonoBehaviour
{

    public bool allowVertical;
    public GameObject menuHorizontal;

    public List<RectTransform> cordLib;

    public GameObject menuVertical;

    public GameObject logoVertical;
 

    void Start(){
        if(!allowVertical){
            Screen.autorotateToPortrait = false;
            menuVertical.SetActive(false);
            menuHorizontal.SetActive(true);
            if(logoVertical != null){
                logoVertical.SetActive(false);
            }
            
        }
        else{
            Screen.autorotateToPortrait = true;
            menuHorizontal.SetActive(false);
            menuVertical.SetActive(true);
            if(logoVertical != null){
                logoVertical.SetActive(true);
            }
            

        }
    }
    void FixedUpdate(){
        if (allowVertical){
            if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight){
                menuHorizontal.SetActive(true);
                menuVertical.SetActive(false);

                if (logoVertical != null){
                    logoVertical.SetActive(false);
                }

            }
            else if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown){
                menuHorizontal.SetActive(false);
                menuVertical.SetActive(true);
                if (logoVertical != null){
                    logoVertical.SetActive(true);
                }
            }
        }
    }
}
