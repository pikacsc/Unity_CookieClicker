using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour {

    
    public GameObject m_GameAreaObject;
    public GameObject m_MenuObject;


    
    public void BackToGame()
    {
        m_GameAreaObject.SetActive(true);
        m_MenuObject.SetActive(false);
    }

    public void OnMenu()
    {
        m_GameAreaObject.SetActive(false);
        m_MenuObject.SetActive(true);
    }

}
