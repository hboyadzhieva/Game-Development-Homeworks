using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health;
    private Counter counter;
    
    void Start() {
        counter = gameObject.GetComponent<Counter>();
        health = counter.MAX - 1;  
        
        ZombieShootController.onZombieHitsPlayer += takeDamage;
        counter.setCountNumber(health);
    }

    public void takeDamage() {
        health--;
        counter.setCountNumber(health);
    }
}
