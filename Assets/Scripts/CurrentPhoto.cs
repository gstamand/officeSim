using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentPhoto : MonoBehaviour
{

    public SDcard sdCard;

    int index = 0;
    public RawImage rawImage;

    // Start is called before the first frame update
    void Start()
    {
        rawImage = gameObject.GetComponent<RawImage>();
        rawImage.texture = sdCard.pictures[index];
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void NextPicture()
    {
        index++;
        if (index >= sdCard.pictures.Count) index = 0;
        rawImage.texture = sdCard.pictures[index];
    }
    public void PreviousPicture()
    {
        index--;
        if (index < 0) index = sdCard.pictures.Count - 1;
        rawImage.texture = sdCard.pictures[index];
    }
    
}
