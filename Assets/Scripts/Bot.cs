using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : Player {


    private float safeZone = 0.35f;

    private static float chance = 0.04f;
    void FixedUpdate() {


        if (Game.gameStarted) {
            List<Player> players = new List<Player>();
            List<Player> compareList = new List<Player>();
            players = instance.playersList;
            players.Remove(this);
            foreach (Player p in players) {
                if (Compare(p, Game.colorMode)) {
                    compareList.Add(p);
                }
            }
            players.Add(this);
            if (compareList.Count > 0) {
                safeZone -= Time.fixedDeltaTime;
                System.Random rnd = new System.Random();

                if (rnd.NextDouble() <= Bot.chance && safeZone <= 0) {
                    safeZone = 0.25f;
                    CompareAll();
                }

            }
        }
    }
    private bool Compare(Player player, bool colorMode) {
        if (!colorMode) {
            if (this.figures[0].shape == player.figures[0].shape) {
                return true;
            }
            return false;
        }
        if (this.figures[0].color == player.figures[0].color) {
            return true;
        }
        return false;
    }
}