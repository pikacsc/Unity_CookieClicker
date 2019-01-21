using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalBGChanger : MonoBehaviour {

    public  GameObject m_Background;
    private int        m_CurrentCash;

	
	// Update is called once per frame
	void Update () {
        m_CurrentCash = GlobalCash.s_CashCount;
        if (m_CurrentCash == 100)
            m_Background.GetComponent<BackGround>().ChangeLevel2BackGround();
        if (m_CurrentCash == 500)
            m_Background.GetComponent<BackGround>().ChangeLevel3BackGround();
    }
}
