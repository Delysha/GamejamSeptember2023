using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKillEnemy : MonoBehaviour
{
    public string targetTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == targetTag) 
        { 
            Destroy(collision.gameObject);
        }
    }
}
