using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPicturesIcon : ClickableIcon
{

    public GameObject photoViewer;
    public GameObject currentPhoto;

    public override void OnClick()
    {
        photoViewer.SetActive(true);
        currentPhoto.SetActive(true);
    }
}
