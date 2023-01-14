using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject settingsWindow;
    public GameObject inventoryWindow;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    void Paused()
    {
        mainPlayer.instance.GetComponent<CharController_Motor>().enabled= false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void Resume()
    {

        mainPlayer.instance.GetComponent<CharController_Motor>().enabled= true;
        pauseMenuUI.SetActive(false);
        settingsWindow.SetActive(false);
        inventoryWindow.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    public void Inventorydisplay()
    {
        inventoryWindow.SetActive(true);

    }
    public void InventoryClose()
    {
        inventoryWindow.SetActive(false);
    }

    public void SetSensibility()
    {
        mainPlayer.instance.GetComponent<CharController_Motor>().sensitivity = slider.value;
    }
    
}
