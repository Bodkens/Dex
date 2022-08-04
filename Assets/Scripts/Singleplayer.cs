using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleplayer : Game
{
    // Start is called before the first frame update
    public GameObject player;

    public GameObject bot;
    public override void onStart(){
        Screen.autorotateToPortrait = true;

        //this.playersList.Add();
    }
    
}
