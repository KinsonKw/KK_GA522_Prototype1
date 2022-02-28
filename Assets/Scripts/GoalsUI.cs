using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalsUI : MonoBehaviour
{
    [SerializeField] private Goals blue;
    [SerializeField] private Goals green;
    [SerializeField] private Goals pink;
    [SerializeField] private Goals purple;
    [SerializeField] private Goals orange;
    [SerializeField] private Goals blueSwirl;
    [SerializeField] private Goals greenSwirl;
    [SerializeField] private Goals pinkSwirl;
    [SerializeField] private Goals purpleSwirl;
    [SerializeField] private Goals orangeSwirl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UIChange(string type, int counters)
    {
        if(type == "bean_blue")
        {
            blue.CounterUpdate(counters);
        }
        else if(type == "bean_green")
        {
            green.CounterUpdate(counters);
        }
        else if (type == "bean_purple")
        {
            purple.CounterUpdate(counters);
        }
        else if (type == "bean_orange")
        {
            orange.CounterUpdate(counters);
        }
        else if (type == "bean_pink")
        {
            pink.CounterUpdate(counters);
        }
        else if (type == "swirl_blue")
        {
            blueSwirl.CounterUpdate(counters);
        }
        else if (type == "swirl_pink")
        {
            pinkSwirl.CounterUpdate(counters);
        }
        else if (type == "swirl_orange")
        {
            orangeSwirl.CounterUpdate(counters);
        }
        else if (type == "swirl_green")
        {
            greenSwirl.CounterUpdate(counters);
        }
        else if (type == "swirl_purple")
        {
            purpleSwirl.CounterUpdate(counters);
        }
    }
}
