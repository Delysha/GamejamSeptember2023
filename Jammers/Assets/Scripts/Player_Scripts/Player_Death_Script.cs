using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Death_Script : MonoBehaviour
{
    BoxCollider2D myBoxCollider2d;

    public bool hasDied = false;
    void Start()
    {
        myBoxCollider2d = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (myBoxCollider2d.IsTouchingLayers(LayerMask.GetMask("Hazerds")))
        {
            hasDied = true;

        }

       if (hasDied == true) 
       {
            SceneManager.LoadScene("Level_1");
       } 
    }
}
