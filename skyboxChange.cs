﻿using UnityEngine;
using System.Collections;

public class skyboxChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeToDuoc(Material sky){
		RenderSettings.skybox = sky;
	}
}
