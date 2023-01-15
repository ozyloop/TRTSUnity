using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    
    public GameObject mainMenuUI;
    public GameObject gameOverUI;
    public Animator fadeSystem;

    public GameObject settingsWindow;
    // Start is called before the first frame update
    public void StartGame(string levelToLoad)
    {
        //fadeSystem.SetTrigger("FadeIn");
        settingsWindow.transform.GetChild(7).gameObject.SetActive(true);
        SceneManager.LoadScene(levelToLoad);
        
        gameOverUI.SetActive(false);
        mainMenuUI.SetActive(false);
        
        
            fadeSystem.SetTrigger("FadeOut");

            InstanceHealthBar.instance.gameObject.SetActive(true);
        
        
    }

    public void SettingsButton()
    {
        settingsWindow.SetActive(true);
    }
    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
    
    

}
