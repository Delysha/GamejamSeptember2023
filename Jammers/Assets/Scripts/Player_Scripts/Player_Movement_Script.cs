using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Script : MonoBehaviour
{
    public Rigidbody2D myRigibody2d;
    public BoxCollider2D myBoxCollider2D;

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpHeight = 10f;

    bool isGrounded = false;

    void Start()
    {
        myRigibody2d = GetComponent<Rigidbody2D>();
        myBoxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        SideMovement();
        JumpMovement();
    }

    void SideMovement() 
    {
        if(Input.GetKey(KeyCode.A)) 
        {
            myRigibody2d.transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            myRigibody2d.transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
        }
    }

    void JumpMovement() 
    {
        if (!myBoxCollider2D.IsTouchingLayers(LayerMask.GetMask("Ground"))) 
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigibody2d.velocity += new Vector2(0, jumpHeight);
        }
    }
}
