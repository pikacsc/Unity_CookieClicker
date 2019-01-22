using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {

    public static bool m_IsLoading = false;

    public GameObject m_MainMenuObject;
    public GameObject m_OptionMenuObject;

    
    public void NewGame()
    { 
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        m_IsLoading = true;
        SceneManager.LoadScene(1);
    }

    public void Option()
    {
        m_OptionMenuObject.SetActive(true);
        m_MainMenuObject.SetActive(false);
    }

    public void BackToMainMenu()
    {
        m_OptionMenuObject.SetActive(false);
        m_MainMenuObject.SetActive(true);
    }


}
