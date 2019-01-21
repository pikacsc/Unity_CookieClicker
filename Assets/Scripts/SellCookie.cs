using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour {

    public GameObject   m_TextBox;
    public GameObject   m_StatusBox;
    public AudioSource  m_AudioCashOne;
    public AudioSource  m_AudioCashTwo;
    public int          m_generateTone;
    public AudioSource  m_AudioNoCookie;

    public void OnClick()
    {
        m_generateTone = Random.Range(1, 3);
        if( GlobalCookies.s_CookieCount == 0)
        {
            m_AudioNoCookie.Play();
            m_StatusBox.GetComponent<Text>().text = "Not enough cookies to sell.";
            m_StatusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            if(m_generateTone == 1)
            {
                m_AudioCashOne.Play();
            }
            if (m_generateTone == 2)
            {
                m_AudioCashTwo.Play();
            }
            GlobalCookies.s_CookieCount -= 1;
            GlobalCash.s_CashCount += 1;
        }
    }

}
