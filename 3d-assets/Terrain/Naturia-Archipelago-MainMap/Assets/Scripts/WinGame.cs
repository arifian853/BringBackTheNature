using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    public AudioClip popSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(popSound, transform.position);
        }
    }

}
