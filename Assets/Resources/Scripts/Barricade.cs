using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour {

    int health;
    Sprite barricadeSprite;

    // Use this for initialization
    void Start() {
        barricadeSprite = Resources.Load("BarricadeState1") as Sprite;
        health = 100;
    }

    // Update is called once per frame
    void Update() {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
            DecreaseHealth(10);
    }

    void DecreaseHealth(int amount) {
        health = -amount;
    }
}
