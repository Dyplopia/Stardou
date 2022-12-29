using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    public void PlayStardou(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void QuitStardou()
    {
        Application.Quit();
    }
}
