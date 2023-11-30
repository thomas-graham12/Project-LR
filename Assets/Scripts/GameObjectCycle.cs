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
    [SerializeField] private GameObject turnOnSoundGO;
    [SerializeField] private GameObject turnOffSoundGO;
    

    public void ChangeGameObject()
    {
        GameObjectsToAppear();
    }

    void GameObjectsToAppear()
    {
        if (numberInList >= listOfGameObjects.Count)
        {
            for (int i = 0; i < listOfGameObjects.Count; i++)
            {
                listOfGameObjects[i].SetActive(false);
                
                turnOnSoundGO.SetActive(false);
                turnOffSoundGO.SetActive(true);
            }

            numberInList = 0;
        }
        else
        {
            for (int i = 0; i < listOfGameObjects.Count; i++)
            {
                listOfGameObjects[i].SetActive(true);
                
                turnOffSoundGO.SetActive(false);
                turnOnSoundGO.SetActive(true);
            }

            numberInList++;
        }
    }
}
