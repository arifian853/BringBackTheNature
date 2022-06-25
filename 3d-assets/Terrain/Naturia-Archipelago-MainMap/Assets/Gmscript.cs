using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gmscript : MonoBehaviour
{
    public GameObject GameOver;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Health();
    }

    public void Health()
    {
        if(currentHealth == 0)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("MENUS");

        }
    }

}
