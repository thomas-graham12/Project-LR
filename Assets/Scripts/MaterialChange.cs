using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;

public class MaterialChange : MonoBehaviour
{
    [SerializeField] private int numberInList;
    [SerializeField] private List<Material> listOfMaterials = new List<Material>();
    AudioSource _audio;
    Renderer _rend;
    private VideoPlayer _videoPlayer;
    [SerializeField] private GameObject turnOnSoundGO;
    [SerializeField] private GameObject turnOffSoundGO;

    private void Start()
    {
        _rend = GetComponent<Renderer>();
        _videoPlayer = GetComponent<VideoPlayer>();
        _audio = GetComponent<AudioSource>();
    }

    public void ChangeMaterial()
    {
        MaterialToAppear();
    }

    void MaterialToAppear()
    {
        if (numberInList == 1)
        {
            _videoPlayer.enabled = false;
            
            _audio.enabled = false;
            turnOnSoundGO.SetActive(false);
            turnOffSoundGO.SetActive(true);

            
            numberInList = 0;
        }
        else
        {
            _videoPlayer.enabled = true;

            _audio.enabled = true;
            turnOffSoundGO.SetActive(false);
            turnOnSoundGO.SetActive(true);
            
            numberInList++;
        }
    }
}
