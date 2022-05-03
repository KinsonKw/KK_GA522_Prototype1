using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapPoint : MonoBehaviour
{
    public Image mode = null;
    public Image category = null;
    public Button button = null;

    public int index = 0;
    [SerializeField] private MapPointInfo info = null;
    [SerializeField] private MapController controller = null;

    public List<MapPoint> connectedNodes = new List<MapPoint>();

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
        for(int i = 0; i < connectedNodes.Count; i++)
        {
            connectedNodes[i].SetInteractable(true);
        }
    }
}
