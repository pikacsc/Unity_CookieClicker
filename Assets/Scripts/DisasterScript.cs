using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour {

    public GameObject   m_StatusText;
    public float        m_CookieCheck;
    public int          m_GenChance;
    public bool         m_DisasterActive = false;
    public int          m_cookieLoss;


    void Update () {
        m_CookieCheck = GlobalCookies.s_CookieCount / 10;
        if(m_DisasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
	}

    IEnumerator StartDisaster()
    {
        m_DisasterActive = true;
        m_GenChance = Random.Range(1, 20);
        if(m_CookieCheck >= m_GenChance)
        {
            m_cookieLoss = Mathf.RoundToInt(GlobalCookies.s_CookieCount * 0.25f);
            m_StatusText.GetComponent<Text>().text = "You lost " + m_cookieLoss + " cookies in a fire";
            GlobalCookies.s_CookieCount -= m_cookieLoss;
            yield return new WaitForSeconds(3);
            m_StatusText.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            m_StatusText.SetActive(false);
            m_StatusText.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        m_DisasterActive = false;
    }
}
