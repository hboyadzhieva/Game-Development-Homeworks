using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieShootController : MonoBehaviour {

    public static event Action onZombieHitsPlayer;

    public void shootStraigth() {
        RaycastHit hit;
        Physics.Raycast(transform.position, -transform.forward, out hit);
        if (hit.collider.gameObject.CompareTag("Player")) {
            Debug.Log("shot");
            onZombieHitsPlayer?.Invoke();
        }
    }
}
