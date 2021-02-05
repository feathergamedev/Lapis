﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoSingleton<AudioManager>
{
    private List<AudioSource> audioTracks;
    private Dictionary<ESoundEffectType, Tuple<AudioClip, float>> soundEffectDic;

    private SoundEffectTable soundEffectTable;

    public override void Init()
    {
        base.Init();
        audioTracks = new List<AudioSource>();
        soundEffectDic = new Dictionary<ESoundEffectType, Tuple<AudioClip, float>>();

        soundEffectTable = Resources.Load<SoundEffectTable>("SoundEffectTable");

        var newTrack = new GameObject($"audio_track_0").AddComponent<AudioSource>();
        newTrack.transform.SetParent(transform);
        audioTracks.Add(newTrack);

        foreach (var pair in soundEffectTable.SoundEffectPairs)
            soundEffectDic.Add(pair.Type, Tuple.Create(soundEffectTable.FindClip(pair.Type), pair.AudioVolume));
    }

    public void PlaySFX(ESoundEffectType type, int trackNumber = 0)
    {
        var soundEffect = soundEffectDic[type];
        audioTracks[trackNumber].PlayOneShot(soundEffect.Item1, soundEffect.Item2);
    }
}