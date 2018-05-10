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
		Text = GameObject.Find ("Text");
		script = Text.GetComponent<Textscore> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = "Level:" + script.Level;
		}
}

