using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
        Debug.Log("Settings opened!");
        GameObject settingsPanel = GameObject.Find("SettingsPanel");
        if (settingsPanel != null)
        {
            settingsPanel.SetActive(true);
        }
    }

    public void B_CloseSettings()
    {
        Debug.Log("Settings closed!");
        GameObject settingsPanel = GameObject.Find("SettingsPanel");
        if (settingsPanel != null)
        {
            settingsPanel.SetActive(false);
        }
    }
}



/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
    Debug.Log("Settings opened!");
    GameObject settingsPanel = GameObject.Find("SettingsPanel");
    if (settingsPanel != null)
    {
        settingsPanel.SetActive(true);
    }
}

public void B_CloseSettings()
{
    Debug.Log("Settings closed!");
    GameObject settingsPanel = GameObject.Find("SettingsPanel");
    if (settingsPanel != null)
    {
        settingsPanel.SetActive(false);
    }
}
}

*/