using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HotSeat : Game {

    public Player p1;

    public Player p2;

    public Player p3;

    public Player p4;

    public override void onStart() {


        Screen.autorotateToPortrait = false;
        playersList = new List<Player>();
        p1.Create();
        p2.Create();
        playersList.Add(p1);
        playersList.Add(p2);

        switch (players) {


            case 3:
                p3.Create();
                p3.objectOfPlayer.SetActive(true);
                playersList.Add(p3);
                break;


            case 4:
                p3.Create();
                p4.Create();
                playersList.Add(p3);
                playersList.Add(p4);
                p3.objectOfPlayer.SetActive(true);
                p4.objectOfPlayer.SetActive(true);
                break;
        }

    }
}
