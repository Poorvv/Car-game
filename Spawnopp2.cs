using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnopp2 : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Rigidbody2D rb;
    void Start()
    {
        Instantiate(objectToSpawn,transform.position,transform.rotation);
        rb.velocity= new Vector2(0,-5);

    }
}
