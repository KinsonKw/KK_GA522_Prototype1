using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject button = null;
    public void onClick_Play()
    {
        SceneManager.LoadScene("AreaMapScene");
    }
}
