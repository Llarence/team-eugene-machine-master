using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZanderView : MonoBehaviour {
	//
	//
	//UNUSED CODE
	//
	//
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Updat () {
		if (Input.GetAxis ("MiniH") != 0) {
			transform.position = new Vector3 (128, 128);
		}
		if (Input.GetAxis ("MiniV") != 0) {
			transform.position = new Vector3 (-128, -128);
		}
		if (Input.GetAxis ("MiniH") == 0) {
			transform.position = new Vector3 (128, 128);
		}
		if (Input.GetAxis ("MiniV") == 0) {
			transform.position = new Vector3 (128, 128);
		}
	}
}
