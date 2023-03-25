using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildindex + 1)
    }
}
