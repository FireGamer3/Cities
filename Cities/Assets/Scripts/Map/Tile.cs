using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Defines a Tile
/// </summary>
public class Tile {
    public readonly int x;
    public readonly int y;
    public Tile(int x, int y) {
        this.x = x;
        this.y = y;
    }
    public Vector3 Position() {
        return new Vector3(x, 0, y);
    }
}
