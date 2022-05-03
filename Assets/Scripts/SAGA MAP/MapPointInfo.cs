using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LevelType { Timer = 0, Moves = 1, Both = 2}
public enum LevelCategory { Regular = 0, Reward = 1, Boss = 2, }
[System.Serializable]
public class MapPointInfo
{
    public Transform transform = null;
    
    public LevelType type = LevelType.Moves;
    
    public LevelCategory category = LevelCategory.Regular;
}
