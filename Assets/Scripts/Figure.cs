using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Figure {

    public Sprite shape;

    public Color color;

    public Figure(Sprite s, Color c) {
        this.shape = s;
        this.color = c;
    }
}