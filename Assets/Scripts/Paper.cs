using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Paper : MonoBehaviour
{

    Vector3 targetLocation;
    Vector3 startLocation;
    Hand rightHand;
    public Rigidbody rb;

    float startTime;
    float journeyLength;
    bool moved = false;
    bool grabbed = false;

    // Start is called before the first frame update
    void Start()
    {

        rightHand = GameObject.Find("RightHand").GetComponent<Hand>();
        startLocation = transform.position;
        targetLocation = transform.position + new Vector3(-0.2432f, 0, 0);

        startTime = Time.time;
        journeyLength = Vector3.Distance(startLocation, targetLocation);
    }

    // Update is called once per frame
    void Update()
    {
        if(moved == false)MovePaper();
        if(rightHand.currentAttachedObject != null && grabbed == false)
        {
            if (rightHand.currentAttachedObject == gameObject) IsGrabbed();
        }
    }

    void MovePaper()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * .03f;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startLocation, targetLocation, fractionOfJourney);
        if (transform.position == targetLocation)
        {
            moved = true;
            rb.useGravity = true;
        }
    }

    void IsGrabbed()
    {

        //rb.isKinematic = false;
        //rb.useGravity = true;

        grabbed = true;
    }
}
