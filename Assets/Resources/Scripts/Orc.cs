using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour {

    int health;
    float attackRange;
    float attackSpeed;
    float speed;
    int damage;
    Vector3 orcObjective;
    GameObject lastestTarget;
    Sprite spritePNG;


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
    bool CheckCanAttack(GameObject otherObject)
    {
        if (attackRange + transform.position.x >= otherObject.transform.position.x || attackRange + transform.position.y >= otherObject.transform.position.y)
            return true;
        else return false;
    }
    void Attack()
    {
        //TODO program this

    }
    void DecreaseHealth(int amount)
    {
        health -= amount;
    }
    void MoveToCapturePoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, orcObjective, speed);
    }
    void CreateOrcWarrior()
    {
        health = 100;
        attackRange = 2.5f;
        attackSpeed = 2.5f;
        speed = 1.5f;
        damage = 10;
        spritePNG = Resources.Load("Orc") as Sprite;
    }
    void CreateOrcArcher()
    {
        health = 70;
        attackRange = 7f;
        attackSpeed = 3f;
        speed = 2f;
        damage = 6;
        spritePNG = Resources.Load("OrcRanger") as Sprite;
    }
}
