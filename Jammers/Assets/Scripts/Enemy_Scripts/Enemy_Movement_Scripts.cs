using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement_Scripts : MonoBehaviour
{
    public int lifeTotal = 1;
    [SerializeField] private float Speed = 5f;

    [SerializeField] private int direction = 1;
    public Rigidbody2D rb;

    BoxCollider2D myBoxCollider2D;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myBoxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        EnemyMovement();
    }

    void EnemyMovement() 
    {
        rb.velocity = transform.right * Speed * direction;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        direction *= -1;
    }
}
