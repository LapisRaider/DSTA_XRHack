using System;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Furniture Data", menuName = "Furniture")]
public class FurnitureData : ScriptableObject
{
    public string m_FurnitureName;
    public string m_FurnitureDescription;
    public int m_FurniturePrice;
    public Sprite m_FurnitureImage;

    public FurnitureMaterialData[] m_FurnitureMaterial;
}

[Serializable]
public struct FurnitureMaterialData
{
    public Material m_FurnitureMaterial;
    public Color m_UIColor;
}