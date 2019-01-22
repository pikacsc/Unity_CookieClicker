using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class OptionMenu : MonoBehaviour {

    public AudioMixer m_AudioMixer;
    public GameObject m_SoundSlider;
    public GameObject m_FakeSoundSlider;
    public GameObject m_BGMSlider;
    public GameObject m_FakeBGMSlider;


    public void SetBGMVolume(float volume)
    {
        m_AudioMixer.SetFloat("BGM_volume", volume);
    }

    public void SetSoundVolume(float volume)
    { 
        m_AudioMixer.SetFloat("SOUND_volume", volume);
        GetComponent<AudioSource>().Play();
    }

    public void MuteBGMVolume(bool muteCheck)
    {
        if (muteCheck)
        {
            m_AudioMixer.SetFloat("BGM_volume", -80f);
            m_BGMSlider.SetActive(false);
            m_FakeBGMSlider.SetActive(true);
        }
        else
        {
            m_AudioMixer.SetFloat("BGM_volume", 1f);
            m_BGMSlider.SetActive(true);
            m_FakeBGMSlider.SetActive(false);
        }
    }

    public void MuteSoundVolume(bool muteCheck)
    {
        if (muteCheck)
        {
            m_AudioMixer.SetFloat("SOUND_volume", -80f);
            m_SoundSlider.SetActive(false);
            m_FakeSoundSlider.SetActive(true);
        }
        else
        {
            m_AudioMixer.SetFloat("SOUND_volume", 1f);
            m_SoundSlider.SetActive(true);
            m_FakeSoundSlider.SetActive(false);
        }
    }
}
