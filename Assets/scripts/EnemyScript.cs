using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{

    public GameObject DeathParticle;
    public GameObject Enemy;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Shootable")
        {
            DeathParticle.SetActive(true);
            Destroy(Enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
