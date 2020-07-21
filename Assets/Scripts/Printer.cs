using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Printer : MonoBehaviour
{

    public Texture testImage;
    public GameObject paper;

    public bool testPrint = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (testPrint)
        {
            PrintPicture(testImage);
            testPrint = false;
        }
    }

    public void PrintPicture(Texture image)
    {
        GameObject newPaper = Instantiate(paper, gameObject.transform.position + new Vector3(0.0057f, 0.039f, .012f), gameObject.transform.rotation);
        newPaper.GetComponentInChildren<RawImage>().texture = image;
    }

}
