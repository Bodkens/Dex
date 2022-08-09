using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderScript : MonoBehaviour {
    public GameObject label;

    public GameObject slider;

    public void ChangeText() {
        label.GetComponent<TMP_Text>().text = slider.GetComponent<Slider>().value.ToString();
    }
}
