using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monkey")
        {

            bananaText.bananaAmount += 1;
            

        }
    }
}
