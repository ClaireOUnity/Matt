using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcSpawner : MonoBehaviour {

    public GameObject[] Orcs;
    GameObject[] spawnPoints;
    Sprite orcPNG;

	// Use this for initialization
	void Start () {
        orcPNG = Resources.Load("Orc") as Sprite;
        spawnPoints = GameObject.FindGameObjectsWithTag("spawner");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateOrcPack()
    {
        for(int i = 0; i < 3; i++)
        {
            Orcs[i] = new GameObject();
            Orcs[i].gameObject.tag = "enemy";
            Orcs[i].AddComponent<BoxCollider2D>();
            Orcs[i].AddComponent<SpriteRenderer>();
            Orcs[i].GetComponent<SpriteRenderer>().sprite = orcPNG;
            Orcs[i].AddComponent<Orc>();
            Orcs[i].transform.position = spawnPoints[Random.Range(0, 4)].transform.position;
        }
    }
}
