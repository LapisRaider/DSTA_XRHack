using UnityEngine;

public class PlayerManager : SingletonBase<PlayerManager>
{
    [HideInInspector]
    public FurnitureBehavior m_PrevOpenedUI;

    public void OpenNewUI(FurnitureBehavior m_NewUIOpened)
    {
        if (m_PrevOpenedUI != null && m_PrevOpenedUI != m_NewUIOpened)
        {
            m_PrevOpenedUI.m_FurnitureUI.SetActive(false);
            m_PrevOpenedUI.m_ClickMeUI.SetActive(false);
        }

        m_PrevOpenedUI = m_NewUIOpened;
    }
}
