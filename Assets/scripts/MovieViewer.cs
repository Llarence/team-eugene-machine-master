using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieViewer : MonoBehaviour {

	public VideoClip Video1; 
	public VideoClip Video2;
	public VideoClip Video3;
	public GameObject Text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Starts the video playing functions
		if(Text.GetComponent<Textscore>().Level == 5){
			StartCoroutine (video1Play ());
		}

		if(Text.GetComponent<Textscore>().Level == 9){
			StartCoroutine (video2Play ());

		}
		if(Text.GetComponent<Textscore>().Level == 13){
			StartCoroutine (video3Play ());
		}
	}
	//Plays the video and rotates the camera to see the video
	IEnumerator video1Play (){
		transform.eulerAngles = new Vector3 (0, -90, 0);
		yield return new WaitForSeconds (2);
		GetComponent<VideoPlayer> ().clip = Video1;
		GetComponent<VideoPlayer> ().Play();
	}
	IEnumerator video2Play (){
		transform.eulerAngles = new Vector3 (0, -90, 0);
		yield return new WaitForSeconds (2);
		GetComponent<VideoPlayer> ().clip = Video2;
		GetComponent<VideoPlayer> ().Play();
	}
	IEnumerator video3Play (){
		transform.eulerAngles = new Vector3 (90, 0, 0);
		yield return new WaitForSeconds (2);
		GetComponent<VideoPlayer> ().clip = Video3;
		GetComponent<VideoPlayer> ().Play();
		transform.eulerAngles = new Vector3 (-90, 0, 0);
	}
}
