using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEATH : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;



    // Update is called once per frame
    void Update()
    {
        Pause();
    }

   
   public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MENUS");
    }

}
