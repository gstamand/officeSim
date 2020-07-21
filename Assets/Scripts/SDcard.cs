using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDcard : MonoBehaviour
{

    public List<Texture2D> pictures;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SavePicture(Texture2D picture)
    {
        pictures.Add(picture);
    }
}
