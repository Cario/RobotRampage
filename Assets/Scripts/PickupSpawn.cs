using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] pickups;
    
    void spawnPickup()
    {
        GameObject pickup = Instantiate(pickups[UnityEngine.Random.Range(0, pickups.Length)]);
        pickup.transform.position = transform.position; //Sets position to the PickupSpawn GameObject
        pickup.transform.parent = transform;
    }

    IEnumerator respawnPickup()
    {
        yield return new WaitForSeconds(20);
        spawnPickup();
    }

    void Start()
    {
        spawnPickup();
    }

    public void PickupWasPickedUp()
    {
        StartCoroutine("respawnPickup");
    }
}
