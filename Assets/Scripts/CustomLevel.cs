using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CustomLevel
{
    public string id;
    public float timer;
    public int movesLeft;
    public int row;
    public int col;

    public string boardFile;

    public ShapeCounter[] goal = new ShapeCounter[0];

   
}
