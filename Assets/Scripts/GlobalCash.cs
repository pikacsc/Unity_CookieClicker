using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCash : MonoBehaviour {

    public static int   s_CashCount;
    public GameObject   m_CashDisplay;
    public int          m_InternalCash;


    // Update is called once per frame
    void Update () {
        m_InternalCash = s_CashCount;
        m_CashDisplay.GetComponent<Text>().text = "$ " + m_InternalCash;

    }
}
