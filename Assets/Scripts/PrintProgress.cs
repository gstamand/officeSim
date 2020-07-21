using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintProgress : MonoBehaviour
{

    public Image progressBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progressBar.fillAmount += .0013f;
        if(progressBar.fillAmount == 1)
        {
            progressBar.fillAmount = 0;
            gameObject.SetActive(false);
        } 
    }
}
