using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    //Jacob Tweed(help Danny Adams)

    public bool isPlayer1 = true;

    Paddle paddle;
    KeyCode upKey;
    KeyCode downKey;

	// Use this for initialization
	void Start () {
        paddle = GetComponent<Paddle>();
        if (isPlayer1)
        {
            upKey = KeyCode.W;
            downKey = KeyCode.S;
        }
        else
        {
            upKey = KeyCode.UpArrow;
            downKey = KeyCode.DownArrow;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            paddle.Move(true);
        }
        if (Input.GetKey(downKey))
        {
            paddle.Move(false);
        }
    }
}
