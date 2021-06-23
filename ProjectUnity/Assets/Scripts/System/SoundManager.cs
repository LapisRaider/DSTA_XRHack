using System;
using UnityEngine;

public class SoundManager : SingletonBase<SoundManager>
{
    public Sound[] m_SoundClipList;

    public override void Awake()
    {
        foreach(Sound sound in m_SoundClipList)
        {
            sound.m_Source = gameObject.AddComponent<AudioSource>();
            sound.m_Source.clip = sound.m_Clip;

            sound.m_Source.volume = sound.m_Volume;
            sound.m_Source.pitch = sound.m_Pitch;
            sound.m_Source.loop = sound.m_Loop;
            sound.m_Source.spatialBlend = sound.m_HearingBaseOnDist;
        }
    }

    public void Play(string name)
    {
        Sound playingSound = Array.Find(m_SoundClipList, sound => sound.m_Name == name);

        if (playingSound == null)
            return;

        if (!playingSound.m_Source.isPlaying)
            playingSound.m_Source.Play();
    }

    public void Stop(string name)
    {
        Sound playingSound = Array.Find(m_SoundClipList, sound => sound.m_Name == name);

        if (playingSound == null)
            return;

        playingSound.m_Source.Stop();
    }

    public void Play(string name, AudioSource source)
    {
        Sound playingSound = Array.Find(m_SoundClipList, sound => sound.m_Name == name);

        if (playingSound == null)
            return;

        if (source != null)
        {
            source.clip = playingSound.m_Clip;
            source.Play();
        }
    }
}
