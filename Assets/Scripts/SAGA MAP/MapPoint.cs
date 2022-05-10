using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapPoint : MonoBehaviour
{
    public Image mode = null;
    public Image category = null;
    public Button button = null;

    public int index = 0;

    [SerializeField] private TMP_Text indexLabel = null;
    [SerializeField] private MapPointInfo info = null;
    [SerializeField] private MapController controller = null;


    private void Start()
    {
        button = GetComponent<Button>();
    }
    public  void SetData(int index, MapController controller, Sprite catSprite, Sprite modeSprite, MapPointInfo info)
    {
        this.info = info;
        this.controller = controller;
        this.index = index;

        category.sprite = catSprite;
        mode.sprite = modeSprite;

        indexLabel.text = index.ToString();
    }

    public void OnClick()
    {
        controller.OnClick(index);
    }

    public void SetInteractable(bool interactable)
    {
        button.interactable = interactable;
    }

    public void ActivateConnectedNodes()
    {
        for(int i = 0; i < info.connectedNodes.Count; i++)
        {
            controller.SetInteractable(info.connectedNodes[i], true);
        }
    }

    public void TurnOnIndex(bool enable)
    {
        indexLabel.gameObject.SetActive(enable);
    }
}
