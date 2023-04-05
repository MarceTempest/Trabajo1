using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject[] vidas;
    public void PlayerDamaged()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }
  
    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }

}

