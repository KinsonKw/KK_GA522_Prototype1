using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AreaMapManger : MonoBehaviour
{
    [SerializeField] private GameObject mapButton = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Play()
    {
        SceneManager.LoadScene("LevelMap Scene");
    }
}
