using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;

    public GameObject settingsWindow;
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
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
