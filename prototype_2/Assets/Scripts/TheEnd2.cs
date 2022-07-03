using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd2 : MonoBehaviour
{

    public GameObject parts;
    public GameObject win;
    public GameObject lost;



    private void OnTriggerEnter(Collider other)
    {

        if (bananaText.bananaAmount >= 4)
        {
            win.SetActive(true);
            Destroy(win, 2f);
            parts.SetActive(true);
            Time.timeScale = 0;
            
        }
        else
        {
            lost.SetActive(true);
            Destroy(lost, 2f);
            parts.SetActive(true);
            Time.timeScale = 0;
           
        }


    }
}
