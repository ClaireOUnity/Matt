using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {

    int health;
    bool canMove;
    float attackRange;
    float attackSpeed;
    float speed;
    int damage;


    // Use this for initialization
    void Start()
    {
        canMove = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
            Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
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
    void Move()
    {
        //TODO click and drag what trops you want to move
    }
}
