using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneLoad : MonoBehaviour {

	public string sP;
	public VideoPlayer V;
	public VideoClip vC;

	// Use this for initialization
	public void LoadScene (string s) {
		sP = s;
		StartCoroutine (w ());
	}
	
	// Update is called once per frame
	IEnumerator w () {
		if (sP == "example") {
			V.clip = vC;
			yield return new WaitForSeconds (13);
		}
		SceneManager.LoadScene (sP);
	}
}
