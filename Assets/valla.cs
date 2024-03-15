using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class valla : MonoBehaviour
{
    public GameObject objetoParaPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objetoParaPrefab, new Vector3(0, 0.5f, 0), Quaternion.identity);
        Instantiate(objetoParaPrefab);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
