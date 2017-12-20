using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour {

    public float health;
    Sprite barricadeSprite;
	bool attack;
	public float attackTime;
	bool hasAttacked;

    // Use this for initialization
    void Start() {
        //barricadeSprite = Resources.Load("BarricadeState1") as Sprite;
        health = 100.0f;
		attack = false;
		hasAttacked = false;
		attackTime = 2.0f;
    }

    // Update is called once per frame
    void Update() {

		if (health <= 0)
			Destroy (this.gameObject);

		if (attack && attackTime >= 2.0f) 
		{
			DecreaseHealth (10);
			attackTime = 0;
			hasAttacked = true;
		}

		if (hasAttacked)
			attackTime += 1.0f * Time.deltaTime;
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.tag == "enemy")
			attack = true;
    }

    void DecreaseHealth(float amount) 
	{
        health -= amount;
    }
}
