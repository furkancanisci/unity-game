using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void baslabutonu()
    {
        SceneManager.LoadScene(1);
    }

    public void c�k�sbutonu()
    {
        Application.Quit();
    }
}
