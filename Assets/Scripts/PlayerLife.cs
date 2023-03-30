using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;

    private void Checklife()
    {
        if (life <1)
        {
            Destroy(hearts[0].gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }
    public void PlayerDamaged()
    {
        life--;
        Checklife();
    }

}