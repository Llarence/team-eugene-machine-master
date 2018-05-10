using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class afterCredits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(I());
	}

	// Update is called once per frame
	IEnumerator I () {
		yield return new WaitForSeconds (15);
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		SceneManager.LoadScene ("Menu");
	}
}
