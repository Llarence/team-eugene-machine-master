using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rotate : MonoBehaviour {
	float pitch;
	float yaw;


	// Use this for initialization
	void Start () {
		//Hides the cursor
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		//rotates the player camera
		yaw -= Input.GetAxis("Mouse Y") * 2;
		pitch += Input.GetAxis("Mouse X") * 2;
		transform.eulerAngles = new Vector3(yaw, pitch, 0f);
		if (Input.GetKeyDown ("escape")) {
			//Goes to menu
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene ("Menu");
		}

	}
}
