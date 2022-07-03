using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bananaText : MonoBehaviour
{
    TextMeshProUGUI text;
    public static int bananaAmount;
    
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        bananaAmount = 0;
    }

   
    void Update()
    {
        text.text = bananaAmount.ToString();
    }
}
