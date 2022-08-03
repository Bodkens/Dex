using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour
{

    public Color[] colorLibrary;

    public Sprite[] shapeLibrary; 

    public Sprite[] timerLibrary;

    public List<Player> playersList;

    public bool colorMode;

    public static int players = 2;

    public GameObject winPanel;

    public GameObject winText;

    public static int cards = 35;

    public virtual void FlipAll(){

    }
    public virtual void RefreshAll(){

    }

    public virtual void Win(string p){

    }

    
}
