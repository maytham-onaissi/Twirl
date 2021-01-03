using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed;
    [SerializeField] float jumpPower;
    [SerializeField] float jumpRange;
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
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * movementSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * movementSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * movementSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * movementSpeed);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Vector3 vc = new Vector3(0.0f, jumpRange);
            rb.AddRelativeForce(vc * jumpPower);
        }
    }

}
