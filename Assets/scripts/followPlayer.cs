using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public Transform CameraTransform;
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        CameraTransform.transform.position = playerTransform.transform.position + offset;
    }
}
