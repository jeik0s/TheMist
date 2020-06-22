using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootWeb : MonoBehaviour
{

    float timer = 0.0f;
    public GameObject bulletPrefab;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKey("space") && timer > 2)
        {
            timer = 0;
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = transform.position;
        }
    }
}
