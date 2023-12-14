using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffVolume : MonoBehaviour
{
    private AudioSource _audioSource;

    private float newVol = 0f;

    private float timer = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
}
