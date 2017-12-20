using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcArcher : Orc {

	// Use this for initialization
	void Start () {
        health = 70;
        attackRange = 7f;
        attackSpeed = 3f;
        speed = 2f;
        damage = 6;
        spritePNG = Resources.Load("OrcRanger") as Sprite;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
