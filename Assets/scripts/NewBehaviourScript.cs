using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	Vector3 Move;
	float pitch;
	float H;
	float V;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		//Moves the player
		H = Input.GetAxis ("Horizontal");
		V = Input.GetAxis ("Vertical");
		Move = new Vector3 (H, 0f, V);
		transform.Translate (Move * 6 * Time.deltaTime);
	}

	void Update () {
		//Rotates the player
		pitch += Input.GetAxis ("Mouse X") * 2;
		transform.eulerAngles = new Vector3 (0f, pitch, 0f);
	}
}
