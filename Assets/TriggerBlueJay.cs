using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerBlueJay : MonoBehaviour
{

    public PlayableDirector timeline;
    
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
        StartCoroutine(DelayAnimation());
    }

    public IEnumerator DelayAnimation()
    {
        yield return new WaitForSeconds(5);
        timeline.Play();

    }

}
