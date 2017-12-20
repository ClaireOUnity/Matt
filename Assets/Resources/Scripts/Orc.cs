using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour {

    int health;
    bool canMove;
    float attackRange;
    float attackSpeed;
    float speed;
    int damage;
    Vector3 orcObjective;
    GameObject lastestTarget;
    Sprite spritePNG;
    GameObject barricade1;

	// Use this for initialization
	void Start () {
        canMove = true;
        barricade1 = GameObject.Find("WesternBarricade1");
        orcObjective = GameObject.Find("OrcObjective").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (canMove)
            MoveToCapturePoint();
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "human")
        {
            canMove = false;
            DecreaseHealth(10);
        }
        else if (collision.tag == "barricade")
        {
            canMove = false;
            DecreaseHealth(10);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canMove = true;
    }

    void DecreaseHealth(int amount)
    {
        health -= amount;
    }
    void MoveToCapturePoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, orcObjective, speed);
    }
}
