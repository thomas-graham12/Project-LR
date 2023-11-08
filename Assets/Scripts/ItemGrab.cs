using System;
using System.Collections;
using System.Collections.Generic;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;
using UnityEngine;
using Valve.VR;

public class ItemGrab : MonoBehaviour
{
    public bool itemIsHovered = false;

    public bool triggerHeld = false;

    [SerializeField] GameObject heldItem;

    [SerializeField] Transform rightHand;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rightInput = GetInput(VRInputDeviceHand.Right);
        if (rightInput.GetButton(VRButton.One) && itemIsHovered)
        {
            triggerHeld = true;
            if (triggerHeld)
            {
                heldItem.GetComponent<Rigidbody>().isKinematic = true;
                heldItem.transform.position = rightHand.transform.position;
                heldItem.transform.rotation = rightHand.transform.rotation;
            }
        }
        else
        {
            //heldItem.transform.position = heldItem.transform.position;
            //heldItem.transform.rotation = heldItem.transform.rotation;
            triggerHeld = false;
            heldItem.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var grabbleObject = other.transform.GetComponent<OVRGrabbable>();

        if (grabbleObject)
        {
            heldItem = grabbleObject.gameObject;
            itemIsHovered = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        itemIsHovered = false;
        heldItem = null;
    }

    private IVRInputDevice GetInput(VRInputDeviceHand hand)
    {
        var device = VRDevice.Device;
        return hand == VRInputDeviceHand.Left ? device.SecondaryInputDevice : device.PrimaryInputDevice;
    }
}
