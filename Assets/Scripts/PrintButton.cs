using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintButton : ClickableIcon
{

    public Printer printer;
    public CurrentPhoto currentPhoto;
    public GameObject printingMessge;

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
        printer.PrintPicture(currentPhoto.rawImage.texture);
        printingMessge.SetActive(true);
    }
}
