using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComing : MonoBehaviour
{

    public Transform PlayerTransform;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(PlayerTransform.position.z > 237)
        {
            gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }
    }
}
