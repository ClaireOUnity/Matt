using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour {

    int health;
    bool canRebuild;
    int rebuildCost;
    Sprite barricadeSprite;
    Sprite[] barricadePNGs;
    Sprite rebuildSymbol;

    // Use this for initialization
    void Start() {
        barricadePNGs = Resources.LoadAll("mapAssets/BarricadeStates") as Sprite[];
        rebuildSymbol = Resources.Load("RebuildSymbol") as Sprite;
        health = 100;
        canRebuild = false;
        rebuildCost = 50;
        //GetComponent<SpriteRenderer>().sprite = barricadePNGs[0];
        CalculateCorrectSprite();
    }

    // Update is called once per frame
    void Update() {
        CalculateCorrectSprite();

        // on click call Rebuild();
    }

    void DecreaseHealth(int amount) {
        health = -amount;
    }
    void Rebuild()
    {
        if (canRebuild)
        {
            health = 100;
            canRebuild = false;
            //TODO: reduce coins by 50 maybe on click of button it calls this function and coin class function to reduce coins
        }
    }
    void ChangeSprite(Sprite sprite) {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
    
    void CalculateCorrectSprite()
    {
        /*if (health > 80)
            ChangeSprite(barricadePNGs[0]);
        if (health < 80 && health > 60)
            ChangeSprite(barricadePNGs[1]);
        if (health < 60 && health > 40)
            ChangeSprite(barricadePNGs[2]);
        if (health < 40 && health > 20)
            ChangeSprite(barricadePNGs[3]);
        if (health < 20 && health > 0)
            ChangeSprite(barricadePNGs[4]);
        if (health < 0){
            ChangeSprite(rebuildSymbol);
            canRebuild = true;
        }*/
    }
}
