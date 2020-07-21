using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{

    int flashTimer = 0;
    Light camLight;

    // Start is called before the first frame update
    void Start()
    {
        camLight = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(flashTimer > 0)
        {
            flashTimer--;
            camLight.enabled = false;
        }
    }

    public void StartFlash()
    {
        flashTimer = 3;
        camLight.enabled = true;
    }
}
