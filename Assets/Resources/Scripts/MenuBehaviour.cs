﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void LoadScene(string level)
	{
		Application.LoadLevel(level);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
