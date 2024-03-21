using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Te has chocado ");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Has pisado " + other.name);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
