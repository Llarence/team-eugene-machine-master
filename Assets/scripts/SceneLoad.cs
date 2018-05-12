using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneLoad : MonoBehaviour {

	public string SceneToLoad;
	public VideoPlayer VideoPlayer;
	public VideoClip VideoClip;

	// Use this for initialization
	public void LoadScene (string s) {
		//Goes to a new scene when called
		SceneToLoad = s;
		StartCoroutine (GoToNextScene ());
	}
	
	// Update is called once per frame
	IEnumerator GoToNextScene () {
		//Loads the next scene
		if (SceneToLoad == "example") {
			//Plays tree hitting animation
			VideoPlayer.clip = VideoClip;
			yield return new WaitForSeconds (13);
		}
		SceneManager.LoadScene (SceneToLoad);
	}
}
