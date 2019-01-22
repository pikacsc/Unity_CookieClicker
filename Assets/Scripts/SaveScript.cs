using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveScript : MonoBehaviour {

    public int          m_SaveGameCash;
    public static int   s_SaveValue = 10;
    public GameObject   m_SaveBtn;
    public GameObject   m_SaveText;

	void Update () {
        m_SaveText.GetComponent<Text>().text = "Cost : $" + s_SaveValue;
        m_SaveGameCash = GlobalCash.s_CashCount;
        if(m_SaveGameCash >= s_SaveValue)
        {
            m_SaveBtn.GetComponent<Button>().interactable = true;
        }
        else
        {
            m_SaveBtn.GetComponent<Button>().interactable = false;
        }
    }


    public void SaveTheGame()
    {
        GlobalCash.s_CashCount -= s_SaveValue;
        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.s_CookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.s_CashCount);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.s_bakePerSec);
        PlayerPrefs.SetInt("SavedBakerValue", GlobalBaker.s_bakerValue);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.s_numeberOfShops);
        PlayerPrefs.SetInt("SavedShopValue", GlobalShop.s_shopValue);
        s_SaveValue *= 2;
        PlayerPrefs.SetInt("SavedValue", s_SaveValue);

    }

}
