using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {

    public GameObject m_TextBox;

    public void OnClick(){
        GlobalCookies.s_CookieCount += 1;
    }


}
