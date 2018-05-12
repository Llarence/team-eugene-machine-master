using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Textlevel : MonoBehaviour {
	public Text text;
	GameObject Text;
	Textscore script;

	// Use this for initialization
	void Start () {
		//Set up
		Text = GameObject.Find ("Text");
		script = Text.GetComponent<Textscore> ();
	}

	// Update is called once per frame
	void Update () {
		//Keeps the text updated
		text.text = "Level:" + script.Level;
		}
}

