using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragObject : MonoBehaviour
{


    float pushForce = 0.001f;
    public Transform CameraTransform;
    public Rigidbody rigidbody;
    public Transform PlayerTransform;

    private Vector3 mOffset;
    private float mZCord;


    private void OnMouseDown()
    {
        mZCord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    private Vector3 GetMouseWorldPos()
    {

        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {

        rigidbody.useGravity = false;
        Vector3 speed;
        speed.x = transform.position.x + ((CameraTransform.transform.position.x - transform.position.x) * 1.1f * Time.deltaTime);
        speed.y = transform.position.y + ((CameraTransform.transform.position.y - transform.position.y - 5)*1.1f* Time.deltaTime);
        speed.z = transform.position.z + ((CameraTransform.transform.position.z - transform.position.z + 2) * 1.1f * Time.deltaTime);
        transform.position = speed;

        if (Input.GetMouseButtonDown(1))
        {
            rigidbody.useGravity = false;

            pushForce = pushForce * 2;
            Debug.Log(pushForce);
        }
    }


    private void OnMouseUp()
    {
        rigidbody.useGravity = true;
        //transform.position = GetMouseWorldPos() + mOffset;
        //rigidbody.AddForce(0, 0, +1000);

        Vector3 throwTo;
        throwTo.z = GetMouseWorldPos().z;
        throwTo.x = GetMouseWorldPos().x;
        throwTo.y = PlayerTransform.position.y;

        rigidbody.AddForce((throwTo - transform.position).normalized * 200000 * Time.smoothDeltaTime);
    }

}

  