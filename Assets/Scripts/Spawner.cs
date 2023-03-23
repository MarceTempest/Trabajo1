using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Fruta;
    public float actualtime = 0;
    public float totaltime = 2;
    void Update()
    {
     if(actualtime < totaltime)
        {
            actualtime += 1 * Time.deltaTime;  
            if(actualtime >= totaltime)
            {
                Instantiate(Fruta[Random.Range(0,Fruta.Length)],
                    transform.position, Quaternion.identity);
                actualtime = Random.Range(0.2f, 0.6f);
            }
        } 
    }
}
