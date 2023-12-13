using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateHeavyRain : MonoBehaviour
{
    [SerializeField] private GameObject heavyRain;

    [SerializeField] private float timeUntilHeavyRain;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartHeavyRain());
    }

    IEnumerator StartHeavyRain()
    {
        yield return new WaitForSeconds(timeUntilHeavyRain);
        
        heavyRain.SetActive(true);
    }
    
}
