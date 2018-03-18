using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    public Paddle player1;
    public Paddle player2;

    int player1Score;
    int player2Score;
    int round;

	// Use this for initialization
	void Start () {
        player1.transform.position = new Vector2(-2.85f, 0);
        player2.transform.position = new Vector2(2.85f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
