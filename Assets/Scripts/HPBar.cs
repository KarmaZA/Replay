﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{

    public float HP;
    public float displayHP;
    public Transform bar;
    private void Start()
    {
        //bar = transform.Find("Bar");
        HP = 100;

    }
    public void DecHP()
    {
        HP -= 30;
        if (HP < 0)
        {
            HP = 0;
            FindObjectOfType<GameManager>().KillEnemy();
            FindObjectOfType<EnemyMove>().ShotDead();

        }
    }
    // Update is called once per frame
    void Update()
    {
        displayHP = HP / 100f;
        bar.localScale = new Vector3(displayHP, 1f, 0);
    }
}