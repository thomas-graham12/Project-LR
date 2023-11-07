using System.Collections;
using System.Collections.Generic;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;
using UnityEngine;
using Valve.VR;

public class ItemGrab : MonoBehaviour
{
    public bool triggerPressed = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rightInput = GetInput(VRInputDeviceHand.Right);
        if (rightInput.GetButton(VRButton.One))
        {
            triggerPressed = true;
            Debug.Log("Trigger Held.");
        }
        else
        {
            triggerPressed = false;
            Debug.Log("Trigger Released.");
        }
    }

    private IVRInputDevice GetInput(VRInputDeviceHand hand)
    {
        var device = VRDevice.Device;
        return hand == VRInputDeviceHand.Left ? device.SecondaryInputDevice : device.PrimaryInputDevice;
    }
}
