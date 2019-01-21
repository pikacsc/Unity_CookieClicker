using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

    public GameObject AutoCookie;

    public void StartAutoCookie()
    {
        AutoCookie.SetActive(true);
        GlobalCash.s_CashCount -= GlobalBaker.s_bakerValue;
        GlobalBaker.s_bakerValue *= 2;
        GlobalBaker.m_turnOffButton = true;
        

    }
}
