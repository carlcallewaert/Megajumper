﻿using UnityEngine;
using System.Collections;

public class autostartrecording : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		Everyplay.StartRecording();
		Everyplay.SetMaxRecordingMinutesLength(1);
		//#if UNITY_EDITOR
		//Debug.Log("The video recording is not available in the Unity editor. Please compile and run on a device.");
		//#endif
	}

	
}