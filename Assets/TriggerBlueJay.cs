using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerBlueJay : MonoBehaviour
{

    public PlayableDirector timeline;
    public float delayTime;
    public float cutsceneLength;
    public GameObject animationObject;
    
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
        StartCoroutine(DelayAnimation());
    }

    public IEnumerator DelayAnimation()
    {
        yield return new WaitForSeconds(delayTime);
        timeline.Play();
        yield return new WaitForSeconds(cutsceneLength);
        Destroy(animationObject);

    }

}
