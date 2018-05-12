using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour {
	public Transform T;
	public float movey;
	public float movex;
	public float movez;
	int O;
	int idf;
	int idb;
	float Ti;
	public float Tis;
	Vector3 D;
	bool Di = false;
	public Mesh Lever1;
	public Mesh Lever2;

	void start () {
		O = 0;
	}

	void Update () {
		if (Di == false) {
			movey = movey / Tis;
			movex = movex / Tis;
			movez = movez / Tis;
			Di = true;
		}
		if (idb == 0 && Ti > 0) {
			GetComponent<MeshFilter> ().mesh = Lever2;
			D.Set (movex * Time.deltaTime, movey * Time.deltaTime, movez * Time.deltaTime);
			print (D);
			print (T.position);
			Ti = Ti - Time.deltaTime;
			T.position += D;
			print (T.position);
		}
		if (Ti <= 0) {
			idf = 0;
		}
		if (idf == 0 && Ti > 0) {
			GetComponent<MeshFilter> ().mesh = Lever1;
			D.Set (movex * Time.deltaTime, movey * Time.deltaTime, movez * Time.deltaTime);
			print (D);
			print (T.position);
			Ti = Ti - Time.deltaTime;
			T.position -= D;
			print (T.position);
		}
		if (Ti <= 0) {
			idb = 0;
		}
	}

	void OnTriggerEnter () {
		if (O == 0 && idb == 0) {
			idf = 1;
			print (Ti);
			O = 1;
			Ti = Tis;
			print (Ti);
		}
		if (O == 1 && idf == 0) {
			print (Ti);
			idb = 1;
			O = 0;
			Ti = Tis;
			print (Ti);
		}
	}
}