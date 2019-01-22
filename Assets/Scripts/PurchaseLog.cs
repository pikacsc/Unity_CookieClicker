using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

    public GameObject AutoCookie;
    public GameObject AutoSell;
    public AudioSource playSound;


    public void Update()
    {
        if (GlobalCash.s_CashCount < GlobalBaker.s_bakerValue)
            GlobalBaker.m_turnOffButton = true;
        if (GlobalCash.s_CashCount < GlobalShop.s_shopValue)
            GlobalShop.m_turnOffButton = true;
    }


    public void StartAutoCookie()
    {
        playSound.Play();
        AutoCookie.SetActive(true);
        GlobalCash.s_CashCount -= GlobalBaker.s_bakerValue;
        GlobalBaker.s_bakerValue *= 2;
        GlobalBaker.m_turnOffButton = true;
        GlobalBaker.s_bakePerSec += 1;
        GlobalBaker.s_numeberOfBakers += 1;
    }

    public void StartAutoSell()
    {
        playSound.Play();
        AutoSell.SetActive(true);
        GlobalCash.s_CashCount -= GlobalShop.s_shopValue;
        GlobalShop.s_shopValue *= 2;
        GlobalShop.m_turnOffButton = true;
        GlobalShop.s_shopPerSec += 1;
        GlobalShop.s_numeberOfShops += 1;
    }
}
