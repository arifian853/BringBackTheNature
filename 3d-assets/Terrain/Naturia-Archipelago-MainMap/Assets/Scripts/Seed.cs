using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seed : MonoBehaviour
{
    public AudioClip popSeedSound;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.SeedCollected();
            gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(popSeedSound, transform.position);
        }
    }
}
