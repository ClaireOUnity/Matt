using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeDefence : MonoBehaviour {

	private float speed;
	public Rigidbody2D projectile;
	public GameObject target;
	private float cooldown;
	private float bulletSpeed;

	// Use this for initialization
	void Start () 
	{
		speed = 2.0f;
		bulletSpeed = 50.0f;

		cooldown = 0.0f;

		//target = GameObject.FindGameObjectsWithTag ("enemy");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cooldown <= 0.0f)
		{
			Rigidbody2D bullet;
			bullet = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody2D;
			//bullet.velocity = Vector2.MoveTowards (transform.position, target.transform.position, shoot);

			bullet.AddRelativeForce (new Vector2 (target.transform.position.x, target.transform.position.y));

			//bullet.position = Vector2.MoveTowards (transform.position, target.transform.position, shoot);

			cooldown = 2.0f;
		} 

		cooldown -= Time.deltaTime * 1.0f;
			
	}
}