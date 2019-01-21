using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour {

    public bool m_SellingCookie = false;
    public static int s_CashIncrease = 1;
    public int m_InternalIncrease;


    void Update()
    {
        s_CashIncrease = GlobalShop.s_shopPerSec;
        m_InternalIncrease = s_CashIncrease;
        if (m_SellingCookie == false)
        {
            m_SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
    }

    IEnumerator SellTheCookie()
    {
        if(GlobalCookies.s_CookieCount == 0)
        {
            //do nothing
        }
        else
        {
            GlobalCash.s_CashCount += m_InternalIncrease;
            GlobalCookies.s_CookieCount -= 1;
            yield return new WaitForSeconds(1);
            m_SellingCookie = false;
        }
    }
}
