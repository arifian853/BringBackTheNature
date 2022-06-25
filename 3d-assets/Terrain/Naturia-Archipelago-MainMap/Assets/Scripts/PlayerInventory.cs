using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public GameObject portal;
    public int NumberOfSeed { get; private set; }

    public UnityEvent<PlayerInventory> OnSeedCollected;

    public void SeedCollected()
    {
        NumberOfSeed++;
        OnSeedCollected.Invoke(this);
        if(NumberOfSeed == 4)
        {
            portal.SetActive(true);
        }
    }
}
