using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class riggibody : MonoBehaviour
{
    public bool canJump;
    public float salto = 5.0f;
    private Collision collision;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        jumpIsNedded();
    }
    private void jumpIsNedded()
    {
        if (canJump && Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * salto);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground")){
            canJump = true;
        }
    }
}
