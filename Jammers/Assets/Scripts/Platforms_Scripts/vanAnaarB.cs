using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanAnaarB : MonoBehaviour
{
    public float speed = 2;
    void Update()
    {
        transform.localPosition = new Vector3 
        (Mathf.PingPong(Time.time*speed, 4), transform.localPosition.y, transform.localPosition.z);
    }


}
