using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour {

    protected int health;
    protected float attackRange;
    protected float attackSpeed;
    protected float speed;
    protected int damage;
    protected Vector3 orcObjective;
    protected GameObject lastestTarget;
    protected Sprite spritePNG;


	// Use this for initialization
	void Start () {

        orcObjective = GameObject.Find("OrcObjective").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (CheckCanAttack(null))
            Attack();
        else MoveToCapturePoint();
	}
    protected bool CheckCanAttack(GameObject otherObject)
    {
        if (attackRange + transform.position.x >= otherObject.transform.position.x || attackRange + transform.position.y >= otherObject.transform.position.y)
            return true;
        else return false;
    }
    protected void Attack()
    {
        //TODO program this

    }
    protected void DecreaseHealth(int amount)
    {
        health -= amount;
    }
    protected void MoveToCapturePoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, orcObjective, speed);
    }
}
