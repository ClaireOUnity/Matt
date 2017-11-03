using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class littleEnemy : MonoBehaviour {

	private int health;
	public Transform target;
	public float speed;

	// Use this for initialization
	void Start () 
	{
		health = 10;
	}
	
	// Update is called once per frame
	void Update () 

	{
		if (health > 0) 
		{
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		}
	}
}
