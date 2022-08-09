using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleplayer : Game {
    public Player player;

    public AI bot;
    public override void onStart() {
        Screen.autorotateToPortrait = true;
        player.Create();
        bot.Create();
    }

}
