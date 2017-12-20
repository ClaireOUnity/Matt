using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {

    int health;
    float attackRange;
    float attackSpeed;
    float speed;
    int damage;


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
    void Move()
    {
        //TODO click and drag what trops you want to move
    }
    void CreateHumanWarrior()
    {
        health = 70;
        attackRange = 7f;
        attackSpeed = 3f;
        speed = 2f;
        damage = 6;
    }
    void CreateHumanArcher()
    {
        health = 100;
        attackRange = 2.5f;
        attackSpeed = 2.5f;
        speed = 1.5f;
        damage = 10;
    }
}
