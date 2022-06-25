using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject target;
    
   private void onCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "target")
        {
            Debug.Log("KENA COK");
            target.SetActive(false);
        }
    }
      
}
