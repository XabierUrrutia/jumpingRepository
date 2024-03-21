using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.position += Time.deltaTime * Vector3.forward * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Time.deltaTime * Vector3.back * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
    }
}
