using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {

    public GameObject  m_TextBox;
    public AudioSource m_AudioCookieSound;

    public void OnClick(){
        m_AudioCookieSound.Play();
        GlobalCookies.s_CookieCount += 1;
    }


}
