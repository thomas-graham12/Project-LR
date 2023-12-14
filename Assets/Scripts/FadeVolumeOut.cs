using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeVolumeOut : MonoBehaviour
{

    [SerializeField] private float fadeOutDuration;
    [SerializeField] private float timer = 0;
    private float startingVolume;
    [SerializeField] private float targetVolume = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        startingVolume = AudioListener.volume;
        StartCoroutine(IFadeOutVolume());
    }

    IEnumerator IFadeOutVolume()
    {
        while (timer < fadeOutDuration)
        {
            timer += Time.deltaTime;
            AudioListener.volume = Mathf.Lerp(startingVolume, targetVolume, timer / fadeOutDuration);
            Debug.Log(AudioListener.volume);
            yield return null;
        }
    }
}
