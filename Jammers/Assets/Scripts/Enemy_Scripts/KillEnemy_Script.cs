using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy_Script : MonoBehaviour
{
    public GameObject Enemy_Object;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
