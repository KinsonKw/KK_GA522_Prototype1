using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public List<MapPointInfo> mapPoints = new List<MapPointInfo>();
    public List<MapPoint> sagaPosition = new List<MapPoint>();
    public MapPoint prefab = null;

    public Transform mapPointParent = null;
    [SerializeField] private bool genOnStart = false;

    [Header("Mode Sprites")]
    public Sprite timerSprite = null;
    public Sprite moveSprite = null;
    public Sprite bothSprite = null;

    [Header("Category Sprites")]
    public Sprite regularSprite = null;
    public Sprite rewardSprite = null;
    public Sprite bossSprite = null;

    public int previousIndex = -1;
   

    // Start is called before the first frame update
    void Start()
    {
        if(genOnStart)
        {
            GenerateMapPoint();
        }

        foreach(MapPoint point in sagaPosition)
        {
            point.SetInteractable(false);
        }

        if(previousIndex >= 0 && previousIndex < sagaPosition.Count)
        {
            sagaPosition[previousIndex].ActivateConnectedNodes();
        }
        else
        {
            sagaPosition[0].SetInteractable(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Generate Map Points")]
    private void GenerateMapPoint()
    {
        foreach(MapPoint position in sagaPosition)
        {
            Destroy(position.gameObject);
        }

        sagaPosition.Clear();

        for(int i = 0; i < mapPoints.Count; i++)
        {
            MapPoint point = Instantiate(prefab, mapPointParent);
            point.transform.position = mapPoints[i].transform.position;
            point.SetData(i, this, GetCatSprite(mapPoints[i].category), GetModeSprite(mapPoints[i].type), mapPoints[i]);
            point.gameObject.SetActive(true);

            sagaPosition.Add(point);
        }
    }
    private Sprite GetModeSprite(LevelType type)
    {
        switch (type)
        {
            case LevelType.Timer:
                return timerSprite;

            case LevelType.Moves:
                return moveSprite;

            case LevelType.Both:
                return bothSprite;
        }

        return null;
    }

    private Sprite GetCatSprite(LevelCategory cat)
    {
        switch (cat)
        {
            case LevelCategory.Regular:
                return regularSprite;

            case LevelCategory.Reward:
                return rewardSprite; ;

            case LevelCategory.Boss:
                return bossSprite;
        }

        return null;
    }
    public void OnClick(int index)
    {
        //load game puzzle scene based on selected point
        Debug.LogError("Puzzle: " + index);
    }


}
