/*
This script is used for emulating a Player's "Death" by teleporting the Player back to their latest Checkpoint.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private GameObject player;
    private Vector3 checkPosition;

    void OnCollisionEnter(Collision other)
    {
        player = other.gameObject;
        checkPosition = player.GetComponent<PlayerController>().Checkpoint;
        
        player.transform.position = checkPosition;
    }
}
