using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruta"))
        {
            Destroy(other.gameObject);
            GameManager.instance.AddScore(10);
        }
        if (other.CompareTag("Obstaculo"))
        {
            Destroy(other.gameObject);
            GameManager.instance.AddScore(-10);
        }
    }
}