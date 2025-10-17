using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cameraTransform;
    public GameManager gameManager;

    void Update()
    {


        float moveHorizontal = 0;// Input.GetAxis("Horizontal");
        float moveVertical = 0;//Input.GetAxis("Vertical");
        
        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = -1;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1;
        }
        
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();
        Vector3 direction = forward * moveVertical + right * moveHorizontal;
        rb.AddForce(direction * 5);
    }

}
