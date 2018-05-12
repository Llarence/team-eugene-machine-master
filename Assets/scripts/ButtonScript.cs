using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
	public Transform TargetTransform;
	public float movey;
	public float movex;
	public float movez;
	int HasGone;
	float TimeCountDown;
	public  float TimeMovingTakes;
	Vector3 DirectionVector3;
	bool HasSet = false;
	void start () {
		HasGone = 0;
	}

	void Update () {
		if (HasSet == false) {
			//Makes it so that it doesn't movey/x/z each second, instead it makes it move movey/x/z over the time you want
			movey = movey / TimeMovingTakes;
			movex = movex / TimeMovingTakes;
			movez = movez / TimeMovingTakes;
			DirectionVector3.Set(movex * Time.deltaTime, movey * Time.deltaTime, movez * Time.deltaTime);
			HasSet = true;
		}
		if (HasGone == 1 && TimeCountDown > 0) {
			//Moves it and counts down the time it has passed from when it started moving
			TimeCountDown = TimeCountDown - Time.deltaTime;
			TargetTransform.position += DirectionVector3;
		}
	}

	void OnTriggerStay () {
		//Makes it move when you bump it
		if (HasGone == 0) {
			HasGone = 1;
			TimeCountDown = TimeMovingTakes;
		}
	}
}
