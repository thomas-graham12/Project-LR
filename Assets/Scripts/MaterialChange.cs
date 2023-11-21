using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MaterialChange : MonoBehaviour
{
    [SerializeField] private int numberInList;
    [SerializeField] private List<Material> listOfMaterials = new List<Material>();
    AudioSource _audio;
    Renderer _rend;

    private void Start()
    {
        _rend = GetComponent<Renderer>();
        _audio = GetComponent<AudioSource>();
    }

    public void ChangeMaterial()
    {
        MaterialToAppear();
    }

    void MaterialToAppear()
    {
        if (numberInList == listOfMaterials.Count - 1)
        {
            _rend.material = listOfMaterials[numberInList];
            _audio.enabled = false;
            
            numberInList = 0;
        }
        else
        {
            _rend.material = listOfMaterials[numberInList];

            _audio.enabled = true;
            numberInList++;
        }
    }
}
