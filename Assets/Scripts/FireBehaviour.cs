using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    [SerializeField] private int numberInList;
    [SerializeField] private List<GameObject> listOfGameObjects = new List<GameObject>();
    [SerializeField] private GameObject turnOnSoundGO;
    [SerializeField] private GameObject turnOffSoundGO;
    [SerializeField] private ParticleSystem _particleSystem;

    private void Start()
    {
        _particleSystem = GetComponentInChildren<ParticleSystem>();
    }

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
                var emission = _particleSystem.emission;
                emission.enabled = false;
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
                var emission = _particleSystem.emission;
                emission.enabled = true;
                listOfGameObjects[i].SetActive(true);
                
                turnOffSoundGO.SetActive(false);
                turnOnSoundGO.SetActive(true);
            }

            numberInList++;
        }
    }
}
