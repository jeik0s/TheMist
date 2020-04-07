using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 offset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    private void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per fr  ame
    void Update()
    {
        Vector3 newPos = playerTransform.position + offset;

        //transform.position = playerTransform.transform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
