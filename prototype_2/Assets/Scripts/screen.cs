using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class screen : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject parts;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        endScreen.SetActive(false);
        SceneManager.LoadScene(1);


    }

    public void Next()
    {
        parts.SetActive(false);
        SceneManager.LoadScene(1);
    }
}