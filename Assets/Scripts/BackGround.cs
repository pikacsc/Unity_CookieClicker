using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour {

    public Sprite[] m_BackGroundImageArr;
    
    private void Start()
    {
        GetComponent<Image>().sprite = m_BackGroundImageArr[0];
    }

    public void ChangeLevel1BackGround()
    {
        GetComponent<Image>().sprite = m_BackGroundImageArr[0];
    }


    public void ChangeLevel2BackGround()
    {
        GetComponent<Image>().sprite = m_BackGroundImageArr[1];
    }

    public void ChangeLevel3BackGround()
    {
        GetComponent<Image>().sprite = m_BackGroundImageArr[2];
    }

}
