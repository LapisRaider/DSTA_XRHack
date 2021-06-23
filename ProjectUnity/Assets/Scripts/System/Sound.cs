using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    public string m_Name;

    public AudioClip m_Clip;

    [Range(0f,1f)]
    public float m_Volume;
    [Range(0.1f, 3f)]
    public float m_Pitch;
    [Range(0f, 1f)]
    public float m_HearingBaseOnDist = 1.0f;

    public bool m_Loop = false;

    [HideInInspector]
    public AudioSource m_Source;
}
