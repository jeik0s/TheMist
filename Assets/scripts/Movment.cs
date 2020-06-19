using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public Rigidbody playerRB;
    public Transform playerTF;
    public float speed = 200f;
    void Update()
    {
        if (Input.GetKey("w"))
            playerRB.AddForce(0, 0, -speed * Time.deltaTime);
        if (Input.GetKey("s"))
            playerRB.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("a"))
            playerRB.AddForce(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey("d"))
            playerRB.AddForce(speed * -Time.deltaTime, 0, 0);
    }
}
