using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    float speed = 8f;
    Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        float randomX = Random.Range(0.5f*speed, speed);
        float randomY = Random.Range(-speed, speed);
        float xNegPos = Random.Range(0f, 1f);
        if (xNegPos <= 0.5f) xNegPos = -1;
        else xNegPos = 1;
        rigid = GetComponent<Rigidbody2D>();
        rigid.AddForce(new Vector2(randomX * xNegPos, randomY));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
