using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pick")  //pick:toplamak , tagi pick olan objeye temas edince Stairs fonksiyonuna git..
        {
            StackManager.instance.PickUp(other.gameObject, true, "Untagged");
        }
    }
}

