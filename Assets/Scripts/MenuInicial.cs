using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildindex + 1);
    }

    public void Salir()
    {
        Debug.Log("salir...");
        Application.Quit();
    }
}
