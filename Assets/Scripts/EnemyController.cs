﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class EnemyController : MonoBehaviour {

    public Text textObject;
    private int hp;

    private GameObject blood;

	void Start () {
        hp = 100;

        blood = Resources.Load<GameObject>("Prefabs/Blood");
    }
	
	void Update () {
        textObject.text = "Enemy HP: " + hp + "%";
	}

    public void ApplyHitByPlayer(PlayerController playerController)
    {
        Instantiate(blood, transform.position, Quaternion.Euler(90, 0, 0));
        hp -= 10;
    }
}