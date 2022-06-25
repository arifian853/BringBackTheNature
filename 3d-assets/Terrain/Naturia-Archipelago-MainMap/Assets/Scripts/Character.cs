using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHealth;
    public HealthBar healthBar;

    private int curHealth;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        curHealth -= damage;
        healthBar.updateHealth((float)curHealth / (float)maxHealth);
    }

}
