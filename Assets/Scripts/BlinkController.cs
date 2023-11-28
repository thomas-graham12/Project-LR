using System;
using System.Collections;
using System.Collections.Generic;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;
using UnityEngine;
using Valve.VR;
public class BlinkController : MonoBehaviour
{
    public bool _isBlinking = false;
    private Animator _animator;
    [SerializeField] Transform leftHand;
    private void Awake()
    {
        _animator = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool("isBlinkingAnim", _isBlinking);
        var leftInput = GetInput(VRInputDeviceHand.Right);
        if (leftInput.GetButton(VRButton.One) && !_isBlinking)
        {
            Blink();
        }
        else if (!leftInput.GetButton(VRButton.One) && _isBlinking)
        {
            _animator.Play("Idle");
            DisableBlink();
        }
    }

    void Blink()
    {
        _isBlinking = true;
        _animator.Play("Blink");
    }

    void DisableBlink()
    {
        if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            _isBlinking = false;
        }
    }
    
    private IVRInputDevice GetInput(VRInputDeviceHand hand)
    {
        var device = VRDevice.Device;
        return hand == VRInputDeviceHand.Left ? device.SecondaryInputDevice : device.PrimaryInputDevice;
    }
}
