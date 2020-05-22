using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootController : MonoBehaviour {

    public static event Action onShootWeapon;

    public static void shoot() {
        onShootWeapon.Invoke();
    }
}
