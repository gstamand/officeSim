using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{

    public Transform[] clickableIcons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickMouse()
    {
        for(int i = 0; i < 4; i++)
        {
            float distanceSqr = (transform.position - clickableIcons[i].position).sqrMagnitude;
            if (Mathf.Sqrt(distanceSqr) < .025f)
            {
                clickableIcons[i].GetComponent<ClickableIcon>().OnClick();
            }
        }
    }

}
