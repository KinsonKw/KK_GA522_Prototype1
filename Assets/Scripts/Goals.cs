using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goals : MonoBehaviour
{
    [SerializeField] private TMP_Text counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CounterUpdate(int counters)
    {
        gameObject.SetActive(counters != 0);
        counter.text = counters.ToString();
    }
}
