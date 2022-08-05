using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameStarter : MonoBehaviour
{
    
    public GameObject playerSlider;

    public GameObject cardsSlider;
    public void SetGameProperties(){
        if(this.playerSlider != null){
            Game.players = (int) playerSlider.GetComponent<Slider>().value;
        }
        if(this.cardsSlider != null){
            Game.cards = (int) cardsSlider.GetComponent<Slider>().value;
        }
        
        
    }
}
