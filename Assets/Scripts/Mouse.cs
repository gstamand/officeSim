using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{

    //shoot a raycast down every .x seconds to see if on table. if on surface, align movement with mouse cursor

    public Image cursor;
    public Rigidbody rb;

    //public bool testForward = false;
    //public bool testForward = false;

    bool isOnSurface = false;

    float mouseYMax = .48f;
    float mouseYMin = -.48f;
    float mouseXMax = .48f;
    float mouseXMin = -.484f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckSurface();
        if(isOnSurface) UpdateCursor();
        //UpdateCursor();
    }

    void CheckSurface()
    {
        if (Physics.Raycast(transform.position, -transform.up, .05f))
        {
            isOnSurface = true;
        }
        else
        {
            isOnSurface = false;
        }
    }

    void UpdateCursor()
    {

        Vector3 currentVelocity = rb.velocity;
        Vector3 currentVelocityLocal = transform.InverseTransformDirection(currentVelocity);

        float yDiff = currentVelocityLocal.x/10;
        float xDiff = -currentVelocityLocal.z/10;

        float oldX = cursor.transform.localPosition.x;
        float oldY = cursor.transform.localPosition.y;

        float newX = oldX += xDiff;
        float newY = oldY += yDiff;

        if (xDiff + oldX > mouseXMax) newX = mouseXMax;
        if (yDiff + oldY > mouseYMax) newY = mouseYMax;

        if (oldX - xDiff < mouseXMin) newX = mouseXMin;
        if (oldY - yDiff < mouseYMin) newY = mouseYMin;

        cursor.transform.localPosition = new Vector3(newX, newY, 0);
    }

}
