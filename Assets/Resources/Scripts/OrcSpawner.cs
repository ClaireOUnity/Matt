using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcSpawner : MonoBehaviour {

	public GameObject orcPNG;
	public int spriteCount;
	public float timer;
	private bool hasSpawned;

	// Use this for initialization
	void Start () {
        
		timer = 3.0f;
		spriteCount = 0;
		hasSpawned = false;
		//Instantiate (orcPNG, transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {

		if (timer >= 3.0f && spriteCount < 1) 
		{
			Instantiate (orcPNG, transform.position, Quaternion.identity);
			spriteCount++;
			hasSpawned = true;
			timer = 0.0f;

			Debug.Log ("spawn");
		}

		if (hasSpawned) 
			timer += Time.deltaTime;
		
		else
			timer = 3.0f;
	}
}
