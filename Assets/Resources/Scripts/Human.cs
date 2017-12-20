using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {

    protected int health;
    protected float attackRange;
    protected float attackSpeed;
    protected float speed;
    protected int damage;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CheckCanAttack(null))
            Attack();
        else Move();
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
    protected void Move()
    {
        //TODO click and drag what trops you want to move
    }
}
