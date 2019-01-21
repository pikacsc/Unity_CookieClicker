using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

    public int m_SavedCookies;
    public int m_SavedCash;
    public int m_SavedBakers;
    public int m_SavedShops;
    public int m_SavedValue;



    void Start () {
	    if(MainMenuOptions.m_IsLoading == true)
        {
            m_SavedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.s_CookieCount = m_SavedCookies;

            m_SavedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.s_CashCount = m_SavedCash;

            m_SavedBakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.s_bakePerSec = m_SavedBakers;

            m_SavedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.s_numeberOfShops = m_SavedShops;

            m_SavedValue = PlayerPrefs.GetInt("SavedValue");
            SaveScript.s_SaveValue = m_SavedValue;
        }
	}
	
}
