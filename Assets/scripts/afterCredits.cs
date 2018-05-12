using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class afterCredits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Calls GoToMenu
		StartCoroutine(GoToMenu());
	}

	// Update is called once per frame
	IEnumerator GoToMenu () {
		//Waits until the credits are done, then goes to the menu scene
		yield return new WaitForSeconds (15);
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		SceneManager.LoadScene ("Menu");
	}
}
