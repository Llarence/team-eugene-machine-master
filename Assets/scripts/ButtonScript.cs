using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
	public Transform T;
	public float movey;
	public float movex;
	public float movez;
	int O;
	float Ti;
	public  float Tis;
	Vector3 D;
	bool Di = false;
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
		if (O == 1 && Ti > 0) {
			D.Set(movex * Time.deltaTime, movey * Time.deltaTime, movez * Time.deltaTime);
			print (D);
			print (T.position);
			Ti = Ti - Time.deltaTime;
			T.position += D;
			print (T.position);
		}
	}

	void OnTriggerStay () {
		if (O == 0) {
			print (Ti);
			O = 1;
			Ti = Tis;
			print (Ti);
		}
	}
}
