using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScript : MonoBehaviour
{
    public Light light;
    public Light light1;
    public Light light2;
    bool alreadyopened = false;
    bool alreadyRotated = false;
    public Transform leftDoor;
    public Transform rightDoor;
    float timer = 0.0f;

    public Camera cutsceneCamera;
    public Camera MainCamera;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (((light.range + light1.range + light2.range) == 15) || alreadyopened == true)
        {
            timer += Time.deltaTime;
            float seconds = timer % 60;


            alreadyopened = true;
            if (seconds < 2)
            {
                leftDoor.rotation *= Quaternion.AngleAxis(-45 * Time.deltaTime, Vector3.up);
                rightDoor.rotation *= Quaternion.AngleAxis(45 * Time.deltaTime, Vector3.up);
            }
            if (seconds < 2.5)
            {
                cutsceneCamera.enabled = true;
                MainCamera.enabled = false;
            }
            else {
                cutsceneCamera.enabled = false;
                MainCamera.enabled = true;
            }

        }
    }
}
