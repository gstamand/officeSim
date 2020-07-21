using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class RightHand : MonoBehaviour
{

    public SteamVR_Action_Boolean indexClick = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("IndexClick");
    public DigitalCamera digitalCamera;
    public SteamVR_Input_Sources handType;
    public Hand hand;
    public Cursor cursor;

    // Start is called before the first frame update
    void Start()
    {
        indexClick.AddOnStateDownListener(IndexClick, handType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IndexClick(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (hand.currentAttachedObject == null) return;
        if (hand.currentAttachedObject.name == "Camera Device")
        {
            digitalCamera.TakePicture();
        }
        if (hand.currentAttachedObject.name == "Mouse")
        {
            //.025 radius
            cursor.ClickMouse();
        }
    }

}
