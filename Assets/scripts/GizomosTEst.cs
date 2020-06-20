using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizomosTEst : MonoBehaviour
{

    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(new Vector3(5,5,5), new Vector3(5, 5, 5));
        Gizmos.color = Color.red;
    }
}
