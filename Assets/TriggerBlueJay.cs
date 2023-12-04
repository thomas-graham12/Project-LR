using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerBlueJay : MonoBehaviour
{

    public PlayableDirector timeline;
    public float delayTime;
    
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
        StartCoroutine(DelayAnimation());
    }

    public IEnumerator DelayAnimation()
    {
        yield return new WaitForSeconds(delayTime);
        timeline.Play();

    }

}
