using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float jumpForce = 6.0f;
    float movementSpeed = 5.0f;

    Rigidbody playerBody;
    float horizontalMovement = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        playerBody.velocity = new Vector3(horizontalMovement * movementSpeed, playerBody.velocity.y, 0f);

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            Debug.Log("The Spacebar has been pressed.");
        }
    }
}
