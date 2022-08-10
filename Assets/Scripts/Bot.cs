using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : Player {

    private List<Player> rivals;

    public void AddRivals(List<Player> players) {
        players.Remove(this);
        foreach (Player p in players) {
            rivals.Add(p);
        }
        players.Add(this);
    }

    //public void


}
