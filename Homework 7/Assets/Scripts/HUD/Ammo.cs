using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private int ammo;
    private Counter counter;

    void Start() {
        this.counter = gameObject.GetComponent<Counter>();
        ammo = counter.MAX - 1;
        PlayerShootController.onShootWeapon += decreaseAmmo;
    }

    void decreaseAmmo() {
        ammo--;
        counter.setCountNumber(ammo);
    }
}
