using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookie : MonoBehaviour {

    public bool         m_CreatingCookie = false;
    public static int   s_CookieIncrease = 1;
    public int          m_InternalIncrease;

    
	void Update () {
        s_CookieIncrease = GlobalBaker.s_bakePerSec;
        m_InternalIncrease = s_CookieIncrease;
        if(m_CreatingCookie == false)
        {
            m_CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
	}

    IEnumerator CreateTheCookie()
    {
        GlobalCookies.s_CookieCount += m_InternalIncrease;
        yield return new WaitForSeconds(1);
        m_CreatingCookie = false;
    }
}
