using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    float speed = 4f;
    Rigidbody2D rigid;
    bool isIdle = true;

    // Use this for initialization
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        StartCoroutine(StartBall());
    }

    IEnumerator StartBall () {
        isIdle = true;
        yield return new WaitForSeconds( 3 );
        transform.position = Vector3.zero;
        float randomY = Random.Range(-speed, speed);
        float xNegPos = Random.Range(0f, 1f);
        if (xNegPos <= 0.5f) xNegPos = -1;
        else xNegPos = 1;
        rigid.velocity = new Vector2(speed * xNegPos, randomY);
        isIdle = false;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if ( isIdle ) return;
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
        StartCoroutine( StartBall() );
    }

}
