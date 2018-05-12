using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour {
	public Transform T;//Target Transform
	public float movey;
	public float movex;
	public float movez;
	int IsItUp;
	int IsDoneMovingUp;
	int IsDoneMovingDown;
	float CountDownTime;
	public float Tis;//Time it takes to move
	Vector3 DirectionToMove;
	bool DidTheRecalculations = false;
	public Mesh Lever1;
	public Mesh Lever2;

	void start () {
		IsItUp = 0;
	}

	void Update () {
		if (DidTheRecalculations == false) {
			//Makes it so that it doesn't movey/x/z each second, instead it makes it move movey/x/z over the time you want
			movey = movey / Tis;
			movex = movex / Tis;
			movez = movez / Tis;
			DidTheRecalculations = true;
		}
		if (IsDoneMovingDown == 0 && CountDownTime > 0) {
			//Moves it toward the place you want and counts down the time it has passed from when it started moving
			GetComponent<MeshFilter> ().mesh = Lever2;
			DirectionToMove.Set (movex * Time.deltaTime, movey * Time.deltaTime, movez * Time.deltaTime);
			CountDownTime = CountDownTime - Time.deltaTime;
			T.position += DirectionToMove;
		}
		if (CountDownTime <= 0) {
			IsDoneMovingUp = 0;
		}
		if (IsDoneMovingUp == 0 && CountDownTime > 0) {
			//Moves it away the place you want and counts down the time it has passed from when it started moving
			GetComponent<MeshFilter> ().mesh = Lever1;
			DirectionToMove.Set (movex * Time.deltaTime, movey * Time.deltaTime, movez * Time.deltaTime);
			CountDownTime = CountDownTime - Time.deltaTime;
			T.position -= DirectionToMove;
		}
		if (CountDownTime <= 0) {
			IsDoneMovingDown = 0;
		}
	}

	void OnTriggerEnter () {
		//Makes it move when you bump it
		if (IsItUp == 0 && IsDoneMovingDown == 0) {
			IsDoneMovingUp = 1;
			IsItUp = 1;
			CountDownTime = Tis;
		}
		if (IsItUp == 1 && IsDoneMovingUp == 0) {
			IsDoneMovingDown = 1;
			IsItUp = 0;
			CountDownTime = Tis;
		}
	}
}