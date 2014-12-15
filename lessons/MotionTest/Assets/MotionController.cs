﻿using UnityEngine;
using System.Collections;

public class MotionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public float motionDistance = 1.0f;
	// Update is called once per frame
	void Update () {
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * motionDistance * Time.deltaTime;
	}

}
