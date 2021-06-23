using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureBehavior : MonoBehaviour
{
    public GameObject m_FurnitureUI = null;
    public GameObject m_ClickMeUI = null;

    private void Awake()
    {
        if (m_ClickMeUI != null)
            m_ClickMeUI.SetActive(false);

        if (m_FurnitureUI != null)
            m_FurnitureUI.SetActive(false);
    }

    // enter looking at furniture
    public void EnterLookAtFurniture()
    {
        //maybe just another click me UI or something
        if (m_ClickMeUI != null)
            m_ClickMeUI.SetActive(true);

    }

    // exit looking at furniture
    public void ExitLookAtFurniture()
    {
        if (m_ClickMeUI != null)
            m_ClickMeUI.SetActive(false);

    }

    // click on furniture
    public void ClickedOnFurniture()
    {
        //bring up UI
        if (m_FurnitureUI != null)
            m_FurnitureUI.SetActive(true);

        if (m_ClickMeUI != null)
            m_ClickMeUI.SetActive(false);
    }
}