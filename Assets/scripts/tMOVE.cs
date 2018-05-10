using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tMOVE : MonoBehaviour {

	int tl;
	public GameObject z;
	public GameObject c;
	public GameObject Tb;
	TextMeshProUGUI T;
	public string[] ss;

	// Use this for initialization
	void Start () {
		T = Tb.GetComponent<TextMeshProUGUI> ();
	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			tl++;
			T.SetText (ss[tl - 1]);
			tl = Mathf.Clamp (tl, 0, 5);
			transform.position = new Vector3 (0 + tl * 15, 0, 0);
			z.transform.position = new Vector3 (tl * 15, 2.5f, 0);
			c.transform.position = new Vector3 (tl * 15, 500, 500);
			Tb.transform.position = new Vector3 (tl * 15, 500, 500);
		}
	}
}
