using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {

    int health;

	// Use this for initialization
	void Start () {
        health = 200;
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
            Application.LoadLevel("Map1");
	}
}
