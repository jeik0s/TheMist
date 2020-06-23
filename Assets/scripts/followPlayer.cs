using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class followPlayer : MonoBehaviour
{
    Transform playerTransform;
    public GameObject Spider;
    public GameObject Player;
    Vector3 offset;
    bool changedInSpider = false;
    bool visibleCursor = false;

    public Text Spell1;
    public Text Spell2;


    bool canChange = true;
    public float coolDown = 5.0f;
    float timer = 0.0f;



    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    private void Start()
    {
        playerTransform = Player.transform;
        offset = transform.position - playerTransform.position;
        Cursor.visible = false;
    }


    // Update is called once per fr  ame
    void Update()
    {
    // TODO : można poprawić to na sprawdzenie tylko raz
        timer += Time.deltaTime;
        float seconds = timer % 60;

        if (Input.GetKey("1") && visibleCursor == false && seconds > 2 && Player.activeSelf == true)
        {
            Spell1.color = Color.red;
            Cursor.visible = true;
            visibleCursor = true;
            timer = 0;
        } else if (Input.GetKey("1") && visibleCursor == true && seconds > 2)
        {
            Spell1.color = Color.black;
            Cursor.visible = false;
            visibleCursor = false;
            timer = 0;

        }


        if (Input.GetKey("2")){
            Debug.Log("zamiana w pajooooonka");
            if (changedInSpider == false && seconds > 2)
            {
                Spell1.color = Color.black;
                Spell2.color = Color.red;
                Cursor.visible = false;
                Debug.Log(timer);
                Spider.transform.position = Player.transform.position;
                Player.SetActive(false);
                Spider.SetActive(true);
                playerTransform = Spider.transform;
                changedInSpider = true;
                timer = 0;
                Debug.Log(timer);

            }
            else if(changedInSpider == true && seconds > 2)
            {
                Spell2.color = Color.black;
                Debug.Log(timer);
                Player.transform.position = Spider.transform.position;
                Player.SetActive(true);
                Spider.SetActive(false);
                playerTransform = Player.transform;
                changedInSpider = false;
                timer = 0;
                Debug.Log(timer);

            }

        }


        // TODO : ustawić zawsze tę samą pozycje
        Vector3 newPos = playerTransform.position + offset;

        //transform.position = playerTransform.transform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
