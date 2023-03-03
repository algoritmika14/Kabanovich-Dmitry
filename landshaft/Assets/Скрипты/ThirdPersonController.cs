using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{

    public float Speed;

    public int forceApplied = 10;
    public bool isGrounded = true;
    private Rigidbody selfRigidbody;

    private void Start()    {
        selfRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()    {
        if (isGrounded)        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                selfRigidbody.AddForce(0, forceApplied, 0, ForceMode.Impulse);
            }
        }

    }

    void Update()    {
        PlayerMovement();

    }
    void OnCollisionExit(Collision other)    {
        if (other.gameObject.tag == "Ground")        {
            isGrounded = false;
        }


    }

    void OnCollisionEnter(Collision other)    {
        if (other.gameObject.tag == "Ground")        {
            isGrounded = true;
        }
    }
    void PlayerMovement()    {
        float horiz = Input.GetAxis("Horizontal");
        float vertic = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(horiz, 0f, vertic).normalized * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }

}
