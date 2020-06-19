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
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "DoNaciskania")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            light.range = 15;
            Debug.Log(pushesClicked);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        pushesClicked = -1;
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "DoNaciskania")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            light.range = 0;
            Debug.Log(pushesClicked);
        }
    }
}
