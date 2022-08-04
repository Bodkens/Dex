using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour
{

    public static Color[] colorLibrary = {new Color(250f/255f, 246f/255f, 84f/255f), new Color(250f/255f, 84f/255f, 198f/255f), new Color(90f/255f, 250f/255f, 84f/255f), new Color(84f/255f, 190f/255f, 250f/255f), new Color(212f/255f, 51f/255f, 19f/255f)};

    public static Sprite[] shapeLibrary;

    public static Sprite[] timerLibrary;

    public List<Player> playersList;

    public static bool colorMode;

    public static int players = 2;

    public GameObject winPanel;

    public GameObject winText;

    public static int cards = 35;

    public virtual void FlipAll(){

    }
    public virtual void RefreshAll(){
        
    }

    public void Start(){

        shapeLibrary = Resources.LoadAll<Sprite>("Figures"); 
        timerLibrary = Resources.LoadAll<Sprite>("Timers");
        onStart();
    }

    public virtual void onStart(){

    }
    public virtual void Win(string p){

    }

    
}
