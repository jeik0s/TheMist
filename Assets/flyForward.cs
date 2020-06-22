using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyForward : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float shootforce;
    public GameObject SpiderTransform;
    Vector3 direction;

    //Vector3 direction = (SpiderTransform.position + SpiderTransform.forward) - SpiderTransform.position;
    //rigidbody.AddForce(direction* pushForce);

    // Start is called before the first frame update
    void Start()
    {
        SpiderTransform = GameObject.Find("Spider_Fuga_Blue_Green");
        direction = (SpiderTransform.transform.position + SpiderTransform.transform.forward) - SpiderTransform.transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(direction * -shootforce);




        Destroy(gameObject, 1);
    }
}
