﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class Constants
{
    public static int Rows = 8;
    public static int Columns = 8;
    public static readonly float AnimationDuration =  0.2f;

    public static readonly float MoveAnimationMinDuration = 0.05f;

    public static readonly float ExplosionDuration = 0.3f;

    public static readonly float WaitBeforePotentialMatchesCheck = 2f;
    public static readonly float OpacityAnimationFrameDelay = 0.05f;

    public static readonly int MinimumMatches = 3;
    public static readonly int MinimumMatchesForBonus = 4;

    public static readonly int Match3Score = 60;
    public static readonly int SubsequentMatchScore = 1000;

    public static void SetDemensions(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
    }
}

   

