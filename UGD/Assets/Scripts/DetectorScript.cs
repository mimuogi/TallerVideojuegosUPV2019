﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{

    private EnemyScript enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponentInParent<EnemyScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {

            enemy.playerDetected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            enemy.playerDetected = false;
        }
        
    }
}
