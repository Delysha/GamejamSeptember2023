using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever_Script : MonoBehaviour
{
    public SpriteRenderer lever_01;
    public SpriteRenderer lever_02;
    public GameObject gate_01;
    public GameObject gate_02;
    public GameObject myPlayer;

    BoxCollider2D myBoxCollider2D;

    bool isSwitchtes = false;

    void Start()
    {
        myBoxCollider2D = GetComponent<BoxCollider2D>();
        lever_02.enabled = false;
        gate_02.SetActive(false);
    }
    void Update()
    {
        Switch();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            //Debug.Log("Works");
            lever_01.enabled = false;
            lever_02.enabled = true;
            isSwitchtes = true;
        }
    }

    void Switch() 
    {
        if(isSwitchtes == true)
        {
            gate_01.SetActive(false);
            gate_02.SetActive(true);
        }
    }
}
