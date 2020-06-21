using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class colliderChecker : MonoBehaviour
{

    public int pushesClicked = 0;
    public Light light;

    void OnCollisionEnter(Collision collision)
    {
        pushesClicked = pushesClicked + 1;

        if (collision.gameObject.name == "DoNaciskania")
        {

            light.range = 15;
            Debug.Log(pushesClicked);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        pushesClicked = -1;
        if (collision.gameObject.name == "DoNaciskania")
        {
            light.range = 0;
            Debug.Log(pushesClicked);
        }
    }
}
