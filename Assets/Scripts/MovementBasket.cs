using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBasket : MonoBehaviour
{
    public float basketSpeed = 20;
    public float min = -8, max = 8;

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * basketSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
          transform.Translate(Vector3.right * Time.deltaTime * basketSpeed);
        }
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, min, max);
        transform.position = pos;
    }
}
