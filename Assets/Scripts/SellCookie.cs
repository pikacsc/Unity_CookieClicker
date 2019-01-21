using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour {

    public GameObject m_TextBox;
    public GameObject m_StatusBox;

    public void OnClick()
    {
        if( GlobalCookies.s_CookieCount == 0)
        {
            m_StatusBox.GetComponent<Text>().text = "Not enough cookies to sell.";
            m_StatusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalCookies.s_CookieCount -= 1;
            GlobalCash.s_CashCount += 1;
        }
    }

}
