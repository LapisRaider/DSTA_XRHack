using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureBehavior : MonoBehaviour
{
    public GameObject m_FurnitureUI = null;

    private bool m_InFurnitureRadius = false;

    private void Awake()
    {
        m_InFurnitureRadius = false;
    }

    // enter looking at furniture
    public void EnterLookAtFurniture()
    {
        if (!m_InFurnitureRadius)
            return;
    }

    // exit looking at furniture
    public void ExitLookAtFurniture()
    {
        if (!m_InFurnitureRadius)
            return;
    }

    // click on furniture
    public void ClickedOnFurniture()
    {
        if (!m_InFurnitureRadius)
            return;

        //bring up UI
        if (m_FurnitureUI == null)
            return;

        m_FurnitureUI.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_InFurnitureRadius = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_InFurnitureRadius = false;
        }
    }
}