using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public static ScoreKeeper Instance;
    public Paddle player1;
    public Paddle player2;
    public int player1Score;
    public int player2Score;
    public Text player1Text;
    public Text player2Text;

    int round = 0;

    // Use this for initialization
    private void Start()
    {
        Instance = this;
        NewGame(); 
        
    }

    // Starts new games/rounds with position
    void NewGame () {
        round++;
        player1Score = 0;
        player2Score = 0;
        player1.transform.position = new Vector2(-2.85f, 0);
        player2.transform.position = new Vector2(2.85f, 0);
	}
	
	// Update is called once per frame
	void Update () {
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }

    // Starting new game based on score
    public void Score(bool isPlayer1)
    {
        if (isPlayer1) player1Score++;
        else player2Score++;
        if (player1Score == 10 || player2Score == 10) NewGame();
    }
}
