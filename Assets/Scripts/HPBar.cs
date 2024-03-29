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
    public void DecHP(float dmg)
    {
        HP -= (dmg != 0) ?  dmg : 100;        
    }
    // Update is called once per frame
    void Update()
    {
        displayHP = HP / 100f;
        bar.localScale = new Vector3(displayHP, 1f, 0);
        if (HP < 1)
        {
            HP = 0;
            FindObjectOfType<GameManager>().KillEnemy();
            FindObjectOfType<EnemyMove>().ShotDead();

        }
    }
}
