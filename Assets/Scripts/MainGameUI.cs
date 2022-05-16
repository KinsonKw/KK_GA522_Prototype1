using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainGameUI : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private TMP_Text boosterText;


    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickBooster()
    {
        panel.SetActive(true);
    }

    public void SetActiveText(string text)
    {
        boosterText.text = text;
        panel.SetActive(true);
    }

    public void OnClickBack()
    {
        Debug.LogError("Click Back");
        panel.SetActive(false);
    }
}
