﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Textscore : MonoBehaviour {
	
	public Text text;
	public int Score;
	public int Level;
	int Hasrest;
	public Vector3[] LS;//Level Start Locations
	public GameObject g;//Player
	public GameObject g1;//Zander
	public Camera CM;//Player camera camera component
	public GameObject CL;//Player camera
	public Camera CMZ;//The reward camera

	// Use this for initialization
	void Start () {
		//Set up
		Score = 0;
		text.text = "Score:" + Score;
	}

	// Update is called once per frame
	void Update () {
		//Keeps the game going
		text.text = "Score:" + Score;
		if (Score == 5) {
			if(Hasrest == 0){
				Hasrest = 1;
				StartCoroutine (reset ());
			}
		}
		if (Input.GetKeyDown ("z") && Input.GetKey ("m") && Input.GetKey ("p")) {
			//Cheat code
			StartCoroutine (reset ());
		}
	}
	IEnumerator reset (){
		//Goes to next and sometimes plays an animation
		Level++;
		CM.enabled = false;
		CMZ.enabled = false;
		CL.SetActive(true);
		yield return new WaitForSeconds (5);
		if (Level == 5) {
			yield return new WaitForSeconds (5);
			CL.transform.eulerAngles = new Vector3 (0, 0, 0);
		}
		if (Level == 9) {
			yield return new WaitForSeconds (2.1f);
			CL.transform.eulerAngles = new Vector3 (0, 0, 0);
		}
		if (Level == 13) {
			yield return new WaitForSeconds (15);
			CL.transform.eulerAngles = new Vector3 (0, 0, 0);
			SceneManager.LoadScene ("Credits");
			yield return new WaitForSeconds (15);
		}
		CM.enabled = true;
		CMZ.enabled = true;
		CL.SetActive(false);
		Score = 0;
		Hasrest = 0;
		g.transform.position = LS [Level - 1];
		Vector3 pos = LS [Level - 1];
		pos = new Vector3 (pos.x, pos.y + 2.5f, pos.z);
		g1.transform.position = pos;
	}
}
