using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChange : MonoBehaviour
{
    [SerializeField] private int numberInList;
    [SerializeField] private Material skyboxOne;
    [SerializeField] private Material skyboxTwo;
    [SerializeField] private Material skyboxThree;
    

    public void ChangeColor()
    {
        Debug.Log("hello");
        ColorChangeOnList();
        
        //if (numberInList == 3)
        //{
        //    numberInList = 0;
        //}
    }

    void ColorChangeOnList()
    {
        switch (numberInList)
        {
            case (0):
                RenderSettings.skybox = skyboxTwo;
                numberInList++;
                break;
            case (1):
                RenderSettings.skybox = skyboxThree;
                numberInList++;
                break;
            case (2):
                RenderSettings.skybox = skyboxOne;
                numberInList = 0;
                break;
        }
    }
}
