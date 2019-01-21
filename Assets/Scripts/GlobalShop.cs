using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalShop : MonoBehaviour {

    public GameObject m_fakeButton;
    public GameObject m_fakeText;
    public GameObject m_realButton;
    public GameObject m_realText;
    public int m_currentCash;
    public static int s_shopValue = 10;
    public static bool m_turnOffButton = false;
    public GameObject m_shopStats;
    public static int s_numeberOfShops;
    public static int s_shopPerSec;

    void Update()
    {
        m_currentCash = GlobalCash.s_CashCount;
        m_shopStats.GetComponent<Text>().text = "Shops: " + s_numeberOfShops + " @ " + s_shopPerSec + " Per Second";
        m_fakeText.GetComponent<Text>().text = "Buy Shop - $" + s_shopValue;
        m_realText.GetComponent<Text>().text = "Buy Shop - $" + s_shopValue;
        if (m_currentCash >= s_shopValue)
        {
            m_fakeButton.SetActive(false);
            m_realButton.SetActive(true);
        }
        if (m_turnOffButton)
        {
            m_realButton.SetActive(false);
            m_fakeButton.SetActive(true);
            m_turnOffButton = false;
        }
    }
}
