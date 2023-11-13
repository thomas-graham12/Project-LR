using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Serialization;

public class ColorCycle : MonoBehaviour
{
    [SerializeField] private int numberInList;
    [SerializeField] private GameObject affectedGameObject;
    [SerializeField] private List<Color> listOfColors = new List<Color>();
    

    public void ChangeColor()
    {
        ColorChangeOnList();
        
        if (numberInList == listOfColors.Count - 1)
        {
            numberInList = 0;
        }
        else
        {
            numberInList++;
        }
    }

    void ColorChangeOnList()
    {
        affectedGameObject.GetComponentInChildren<Renderer>().material.color = listOfColors[numberInList];
    }
}
