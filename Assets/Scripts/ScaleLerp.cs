using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleLerp : MonoBehaviour
{
    private Vector3 minScale;
    [SerializeField] private Vector3 maxScale;
    [SerializeField] private bool repeatable;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float duration = 5f;

    private IEnumerator Start()
    {
        minScale = transform.localScale;

        transform.localScale = minScale;
        do
        {
            yield return IRepeatLerp(minScale, maxScale, duration);
        } while (repeatable);
    }
    
    public IEnumerator IRepeatLerp(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f) 
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }
}
