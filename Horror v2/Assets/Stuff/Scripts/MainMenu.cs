using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsPanel;

    public void B_LoadScene()
    {
        SceneManager.LoadScene("og");
    }

    public void B_QuitGame()
    {
        Application.Quit();
    }

    public void B_OpenSettings()
    {
        Debug.Log("Opening SettingsPanel...");
        settingsPanel.SetActive(true);
    }

    public void B_CloseSettings()
    {
        Debug.Log("Closing SettingsPanel...");
        settingsPanel.SetActive(false);
    }
}

