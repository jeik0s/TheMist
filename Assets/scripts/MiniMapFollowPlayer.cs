using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapFollowPlayer : MonoBehaviour
{

    public Vector3 offset;
    public GameObject Player;
    public GameObject Spider;
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.activeSelf == true)
        {
          transform.position = Player.transform.position + offset;
        } else if (Spider.activeSelf == true)
        {
          transform.position = Spider.transform.position + offset;
        }
    }
}
