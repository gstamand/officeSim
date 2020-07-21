using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SDport : MonoBehaviour
{

    public Hand leftHand;
    public Transform targetTransform;

    GameObject sdCard;
    bool inRange = false;

    bool startMovement = false;
    bool moved = false;

    float startTime;
    float journeyLength;
    Vector3 startLocation;
    Vector3 targetLocation;// = new Vector3(2.5832f, 0.03863999f, -0.236f);
    Quaternion startRotation;
    Quaternion targetRotation;

    // Start is called before the first frame update
    void Start()
    {
        targetRotation = targetTransform.rotation;
        targetLocation = targetTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftHand.currentAttachedObject == null && inRange && startMovement == false) InsertCard();
        if (moved == false && startMovement == true) MoveCard();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "SDcard")
        {
            sdCard = other.gameObject;
            inRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "SDcard")
        {
            inRange = false;
        }
    }

    void InsertCard()
    {
        startMovement = true;
        startTime = Time.time;
        startLocation = sdCard.transform.position;
        startRotation = sdCard.transform.rotation;
        journeyLength = Vector3.Distance(startLocation, targetLocation);
    }

    void MoveCard()
    {
        float distCovered = (Time.time - startTime) * .1f;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        sdCard.transform.position = Vector3.Lerp(startLocation, targetLocation, fractionOfJourney);
        sdCard.transform.rotation = Quaternion.Lerp(startRotation, targetRotation, fractionOfJourney);
        if (sdCard.transform.position == targetLocation)
        {
            moved = true;

        }
    }

}
