using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{   
    public Rigidbody2D rigidbody2D;
    public float Speed = 6f;
    public UiManager UiManager;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        SendBallInRandomDirection();
    }

    private void SendBallInRandomDirection()
    {
        BallReset
        
        rigidbody2D.velocity = Vector3.zero;
        rigidbody2D.isKinematic = true;
        transform.position = Vector3.zero;
        rigidbody2D.isKinematic = false;


        Vector2 newBallVector = new Vector2();
        newBallVector.x = Random.Range(-1f, 1f);
        newBallVector.y = Random.Range(-1f, 1f);
        rigidbody2D.velocity = newBallVector * Speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (transform.position.x >0)
        {
         Debug.Log("Player Left +1");
         LeftPlayerScore++;
         UiManager.SetLeftPlayerScoreText(LeftPlayerScore.ToString()).;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SendBallInRandomDirection();
        }
    }
}