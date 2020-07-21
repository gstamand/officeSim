using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrow : ClickableIcon
{

    public GameObject currentPhoto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnClick()
    {
        currentPhoto.GetComponent<CurrentPhoto>().NextPicture();
    }
}
