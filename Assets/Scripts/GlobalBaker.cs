using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class GlobalBaker : MonoBehaviour {

    public GameObject   m_fakeButton;
    public GameObject   m_fakeText;
    public GameObject   m_realButton;
    public GameObject   m_realText;
    public int          m_currentCash;
    public static int   s_bakerValue = 10;
    public static bool  m_turnOffButton = false;
    public GameObject   m_bakerStats;
    public static int   s_numeberOfBakers;
    public static int   s_bakePerSec;
	
	void Update () {
        m_currentCash = GlobalCash.s_CashCount;
        m_bakerStats.GetComponent<Text>().text = "Bakers: " + s_numeberOfBakers + " @ " + s_bakePerSec + " Per Second";
        m_fakeText.GetComponent<Text>().text = "Buy Baker - $" + s_bakerValue;
        m_realText.GetComponent<Text>().text = "Buy Baker - $" + s_bakerValue;
        if (m_currentCash >= s_bakerValue)
        {
            m_fakeButton.SetActive(false);
            m_realButton.SetActive(true);
        }
        if(m_turnOffButton)
        {
            m_realButton.SetActive(false);
            m_fakeButton.SetActive(true);
            m_turnOffButton = false;
        }
	}
}
