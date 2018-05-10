using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieViewer : MonoBehaviour {

	public VideoClip V1;
	public VideoClip V2;
	public VideoClip V3;
	public GameObject g;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(g.GetComponent<Textscore>().Level == 5){
			StartCoroutine (I ());
		}

		if(g.GetComponent<Textscore>().Level == 9){
			StartCoroutine (i ());

		}
		if(g.GetComponent<Textscore>().Level == 13){
			StartCoroutine (E ());
		}
	}

	IEnumerator I (){
		transform.eulerAngles = new Vector3 (0, -90, 0);
		yield return new WaitForSeconds (2);
		GetComponent<VideoPlayer> ().clip = V1;
		GetComponent<VideoPlayer> ().Play();
	}
	IEnumerator i (){
		transform.eulerAngles = new Vector3 (0, -90, 0);
		yield return new WaitForSeconds (2);
		GetComponent<VideoPlayer> ().clip = V2;
		GetComponent<VideoPlayer> ().Play();
	}
	IEnumerator E (){
		transform.eulerAngles = new Vector3 (90, 0, 0);
		yield return new WaitForSeconds (2);
		GetComponent<VideoPlayer> ().clip = V3;
		GetComponent<VideoPlayer> ().Play();
		transform.eulerAngles = new Vector3 (-90, 0, 0);
	}
}
