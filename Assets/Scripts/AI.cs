using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : Player {
    private float aiCof = 0.34f;

    private System.Random rand = new System.Random();
    void FixedUpdate() {
        aiCof = (float)rand.NextDouble();
    }
}
