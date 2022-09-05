using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField] int bounceForce = 2000;
    Rigidbody playerRb;

    void OnTriggerEnter(Collider other) 
    {
        BounceAway(other);
    }

    void BounceAway(Collider other)
    {
        playerRb = other.gameObject.GetComponent<Rigidbody>();
        playerRb.AddForce(Vector3.up * bounceForce);

    }

}
