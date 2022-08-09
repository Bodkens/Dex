using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAdaptator : MonoBehaviour {
    public RectTransform coordsVertical;
    public RectTransform coordsHorizontal;

    public RectTransform objectCords;

    void FixedUpdate() {
        if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight) {
            objectCords.position = coordsHorizontal.position;
            objectCords.anchorMax = coordsHorizontal.anchorMax;
            objectCords.anchorMin = coordsHorizontal.anchorMin;
        } else if (Screen.orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown) {
            objectCords.position = coordsVertical.position;
            objectCords.anchorMax = coordsVertical.anchorMax;
            objectCords.anchorMin = coordsVertical.anchorMin;

        }
    }

}
