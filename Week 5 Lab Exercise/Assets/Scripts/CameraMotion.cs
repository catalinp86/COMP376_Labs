﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Rotate (Vector3.up * Time.deltaTime);
	}
}
