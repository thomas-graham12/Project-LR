using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Serialization;

public class GameObjectCycle : MonoBehaviour
{
    [SerializeField] private int numberInList;
    [SerializeField] private List<GameObject> listOfGameObjects = new List<GameObject>();
    

    public void ChangeColor()
    {
        GameObjectsToAppear();
    }

    void GameObjectsToAppear()
    {
        if (numberInList >= 1)
        {
            for (int i = 0; i < listOfGameObjects.Count; i++)
            {
                listOfGameObjects[i].SetActive(false);
            }

            numberInList = 0;
        }
        else
        {
            for (int i = 0; i < listOfGameObjects.Count; i++)
            {
                listOfGameObjects[i].SetActive(true);
            }

            numberInList++;
        }
    }
}
