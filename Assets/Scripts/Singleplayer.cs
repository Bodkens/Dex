using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleplayer : Game {
    public Player player;

    public Bot bot;
    public override void onStart() {
        Screen.autorotateToPortrait = true;
        player.Create();
        bot.Create();
        playersList.Add(player);
        playersList.Add(bot);
        bot.AddRivals(playersList);
    }

}
