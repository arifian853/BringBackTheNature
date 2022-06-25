using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEffect : MonoBehaviour
{
    public int healthEffect;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" || other.gameObject.layer == LayerMask.NameToLayer("Mob"))
        {
            if (healthEffect > 0)
                other.gameObject.GetComponent<StatsController>().Heal(healthEffect);
            else if(healthEffect < 0)
            {
                other.gameObject.GetComponent<StatsController>().Damage(Mathf.Abs(healthEffect));
            }
        }
    }
}
