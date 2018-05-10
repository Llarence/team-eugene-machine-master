using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour {

	public AudioClip sf;
	public Material bright;
	public Material dark;
	GameObject Text;
	Textscore script;
	int HasActivated;
	public Mesh m;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().clip = sf;
 		Text = GameObject.Find ("Text");
		script = Text.GetComponent<Textscore> ();
		HasActivated = 0;
	}

	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Player") {
			print (GetComponent<Renderer> ().material);
			if (HasActivated == 0){
				GetComponent<AudioSource> ().Play ();
					script.Score++;
				GetComponent<Renderer> ().material = bright;
				transform.localScale = new Vector3 (transform.localScale.x / 50, transform.localScale.y / 50, transform.localScale.z / 50);
				GetComponent<MeshFilter> ().mesh = m;
				GetComponent<BoxCollider> ().size = new Vector3 (1, 1, 1);
			}
			HasActivated = 1;
		}
	}
}
