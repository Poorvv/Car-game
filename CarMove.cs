using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            transform.position= new Vector2(-1.81f,-4.6f);
        }
        if(Input.GetMouseButtonDown(1))
        {
            transform.position= new Vector2(1.81f,-4.6f);
        }
    }   
    

    
}
