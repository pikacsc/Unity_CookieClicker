using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {

    public static bool m_IsLoading = false;

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        m_IsLoading = true;
        SceneManager.LoadScene(1);
    }
	
}
