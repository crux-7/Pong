using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject player;
    private GameObject player2;
    private float smoothner = 0.2F;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("Player 2");
    }

    void Update()
    {

        //Keyboard Controls
        if (Input.GetAxis("Player 1") > 0)
        {
            player.transform.Translate(0f, Input.GetAxis("Player 1") * smoothner, 0f);      
        }

        if (Input.GetAxis("Player 1") < 0)
        {
            player.transform.Translate(0f, Input.GetAxis("Player 1") * smoothner, 0f);
        }

        if (Input.GetAxis("Player 2") > 0)
        {
            player2.transform.Translate(0f, Input.GetAxis("Player 2") * smoothner, 0f);
        }

        if (Input.GetAxis("Player 2") < 0)
        {
            player2.transform.Translate(0f, Input.GetAxis("Player 2") * smoothner, 0f);
        }

        //Mobile Controls
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
            { 
                player.transform.Translate(0f, Input.GetAxis("Player 1") * smoothner, 0f);
            }
            else if (touch.position.x > Screen.width / 2)
            {
                player.transform.Translate(0f, Input.GetAxis("Player 1") * smoothner, 0f);
            }
        }

    }
}
