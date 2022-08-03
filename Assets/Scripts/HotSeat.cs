using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HotSeat : Game{

    
    
    

    public Player p1;
    
    public Player p2;

    public Player p3;

    public Player p4;
    
    void Start(){
        
        playersList = new List<Player>();
        p1.Create();
        p2.Create();
        playersList.Add(p1);
        playersList.Add(p2);

        switch(players){
            
            
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

    public override void FlipAll(){
        foreach (Player p in playersList){
            p.Flip();
        }
    }

    public override void RefreshAll(){
        foreach (Player p in playersList){
            p.Refresh();
        }
    }

    public override void Win(string p){
        winPanel.SetActive(true);
        winText.GetComponent<TMP_Text>().text = p + " Won!";
        Time.timeScale = 0;
    }



}
