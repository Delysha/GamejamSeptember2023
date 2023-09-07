using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagScript : MonoBehaviour
{
    BoxCollider2D myBoxCollider2D;

    void Start()
    {
        myBoxCollider2D = GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (myBoxCollider2D.CompareTag("Flag")) 
        {
            SceneManager.LoadScene("menu");
        }  
    }
}
