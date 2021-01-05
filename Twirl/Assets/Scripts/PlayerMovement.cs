using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed;
    [SerializeField] float jumpPower;
    [SerializeField] float jumpRange;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move();

    }

    void move()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed, 0.0f, 0.0f);
        transform.Translate(0.0f, 0.0f, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
         if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpPower);
        }
    }

     void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Floor":
                isGrounded = true;
                break;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Floor":
                isGrounded = false;
                break;
        }
    }



}
