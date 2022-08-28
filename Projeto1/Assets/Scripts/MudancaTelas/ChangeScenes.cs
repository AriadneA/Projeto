using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public string nomeCena;
    public void Change()
    {
        SceneManager.LoadScene(nomeCena);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
