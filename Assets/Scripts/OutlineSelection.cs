using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineSelection : MonoBehaviour
{
    // Start is called before the first frame update

    RaycastHit hit;

    [SerializeField] GameObject controllerHand;

    [SerializeField] float range;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(controllerHand.transform.position, controllerHand.transform.forward, out hit))
        {
            if (hit.transform.CompareTag("Selectable"))
            {
                Debug.Log("Hit");
            }
            else
            {
                return;
            }
        }
        
        Debug.DrawRay(controllerHand.transform.position,transform.forward, Color.green);
    }
}
