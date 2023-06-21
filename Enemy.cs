using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D enemy) {
        if(enemy.gameObject.tag=="Player"){
            GameManager.instance.Restart();
        }
    }
}
