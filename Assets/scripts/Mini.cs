using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini : MonoBehaviour {
	float t;
	float w;
	Vector3 Move;
	float pitch;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		float V = Input.GetAxis ("MiniV");
		Move = new Vector3 (0f, 0f, V);
		transform.Translate (Move * 6 * Time.deltaTime);
	}
	void Update (){
		pitch += Input.GetAxis("MiniH") * 120 * Time.deltaTime;
		transform.eulerAngles = new Vector3(0f, pitch, 0f);
	}
}
