using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tMOVE : MonoBehaviour {

	int TutorialLevel;
	public GameObject Zander;
	public GameObject Canvas;
	public GameObject Text;
	TextMeshProUGUI TextWriting;
	public string[] TextString;

	// Use this for initialization
	void Start () {
		//Sets TextWriting to Text's writing
		TextWriting = Text.GetComponent<TextMeshProUGUI> ();
	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			//When the spacebar is down goes to the next tutorial
			TutorialLevel++;
			TextWriting.SetText (TextString[TutorialLevel - 1]);
			TutorialLevel = Mathf.Clamp (TutorialLevel, 0, 5);
			transform.position = new Vector3 (0 + TutorialLevel * 15, 0, 0);
			Zander.transform.position = new Vector3 (TutorialLevel * 15, 2.5f, 0);
			Canvas.transform.position = new Vector3 (TutorialLevel * 15, 500, 500);
			Text.transform.position = new Vector3 (TutorialLevel * 15, 500, 500);
		}
	}
}
