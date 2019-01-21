using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies : MonoBehaviour {

    public static int   s_CookieCount;
    public GameObject   m_CookieDisplay;
    public int          m_InternalCookie; 


	void Update () {
        m_InternalCookie = s_CookieCount;

        m_CookieDisplay.GetComponent<Text>().text = "Cookie: " + m_InternalCookie;
	}
}
