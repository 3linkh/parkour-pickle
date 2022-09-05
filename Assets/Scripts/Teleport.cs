using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Transform teleportDestination;

    void OnTriggerEnter(Collider other)
    {
        TeleportPlayer();
    }

    void TeleportPlayer()
    {
        player.transform.position = teleportDestination.transform.position;

    }

}
