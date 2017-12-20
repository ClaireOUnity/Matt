using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanWarrior : Human
{

    // Use this for initialization
    void Start()
    {
        health = 100;
        attackRange = 2.5f;
        attackSpeed = 2.5f;
        speed = 1.5f;
        damage = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
