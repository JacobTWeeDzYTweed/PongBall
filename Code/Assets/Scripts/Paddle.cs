using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    float speed = 2.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Move(bool isUp)
    {
        int negPos;
        if (isUp) negPos = 1;
        else negPos = -1;
        Vector3 moveVector = new Vector3(0,negPos*speed*Time.deltaTime, 0);
        if(moveVector.y + transform.position.y < 1.3f && moveVector.y + transform.position.y > -1.3f) 
        transform.Translate(moveVector);
         
    } 
}
