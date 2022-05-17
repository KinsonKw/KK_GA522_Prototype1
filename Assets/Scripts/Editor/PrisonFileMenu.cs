using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PrisonFileMenu : MonoBehaviour
{
    [MenuItem("PrisonBreak/Clear Level")]
    public static void ClearLevel()
    {
        PlayerPrefs.SetInt("selectLevel", -1);
    }
}
