using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int lifeTotal = 1;
    [SerializeField] private float Speed = 5f;
    
    [SerializeField] private int direction = 1;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * Speed * direction;  
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       direction *= -1;
    }

}
