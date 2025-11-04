using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 5) transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -5) transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
           
        }

    }
}
