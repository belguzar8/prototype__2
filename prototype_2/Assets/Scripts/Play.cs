using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject go;
  
    public void PlayButton()
    {

        SceneManager.LoadScene(1);
    }

    public void FirstButton()
    {
        SceneManager.LoadScene(2);
    }
    public void SecondButton()
    {
        SceneManager.LoadScene(3);
    }
    public void ThirdButton()
    {
        SceneManager.LoadScene(4);

    }
    public void FourthButton()
    {
        SceneManager.LoadScene(5);
    }
    public void FifthButton()
    {
        SceneManager.LoadScene(6);
    }
}
