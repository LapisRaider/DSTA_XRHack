using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FurnitureUI : MonoBehaviour
{
    [Header("Data for furniture")]
    public FurnitureData m_FurnitureData;
    public MeshRenderer m_FurnitureMeshRenderer;

    [Header("UI infomation")]
    public TextMeshProUGUI m_NameUI;
    public TextMeshProUGUI m_DescriptionUI;
    public TextMeshProUGUI m_PriceUI;
    public Image m_FurnitureImage;

    public Image[] m_MatrialUI;

    // Start is called before the first frame update
    void Start()
    {
        //initialise UI here
        m_NameUI.SetText(m_FurnitureData.m_FurnitureName);
        m_DescriptionUI.SetText(m_FurnitureData.m_FurnitureDescription);
        m_PriceUI.SetText("$ " + m_FurnitureData.m_FurniturePrice);
        m_FurnitureImage.sprite = m_FurnitureData.m_FurnitureImage;

        for (int i = 0; i < m_MatrialUI.Length; ++i)
        {
            if (i >= m_FurnitureData.m_FurnitureMaterial.Length)
            {
                m_MatrialUI[i].gameObject.SetActive(false);
                continue;
            }

            m_MatrialUI[i].color = m_FurnitureData.m_FurnitureMaterial[i].m_UIColor;
        }

        m_NameUI.SetText(m_FurnitureData.m_FurnitureName);
    }


    public void ChangeFurnitureMaterial(int materialIndex)
    {
        if (m_FurnitureMeshRenderer == null)
            return;

        if (materialIndex >= m_FurnitureData.m_FurnitureMaterial.Length)
            return;

        //grab the material, and change the furniture material accordingly
        m_FurnitureMeshRenderer.material = m_FurnitureData.m_FurnitureMaterial[materialIndex].m_FurnitureMaterial;
    }
}
