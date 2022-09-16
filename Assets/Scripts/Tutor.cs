using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor : Player {
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