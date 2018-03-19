﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    float speed = 4f;
    Rigidbody2D rigid;


    // Use this for initialization
    private void Start()
    {
        StartBall();
    }

    void StartBall () {
        float randomY = Random.Range(-speed, speed);
        float xNegPos = Random.Range(0f, 1f);
        if (xNegPos <= 0.5f) xNegPos = -1;
        else xNegPos = 1;
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(speed * xNegPos, randomY);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Mathf.Abs(rigid.velocity.y) <= 1f) rigid.velocity = new Vector2(rigid.velocity.x, speed * 0.5f);
        if (Mathf.Abs(rigid.velocity.x) <= 1f) rigid.velocity = new Vector2(speed * 0.5f, rigid.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string colName = collision.name;
        if (colName == "ScoreDetect-Player1")
        {
            print("player1 Scored!");
            ScoreKeeper.Instance.Score(true);
        }
        else if (colName == "ScoreDetect-Player2")
        {
            print("player2 Scored!");
            ScoreKeeper.Instance.Score(false);
        }
        StartBall();
    }
}
