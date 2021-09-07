using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;
    public float multiplier = 30;
    public float SFXLevel;
    public float MusicLevel;
    public float MasterLevel;
    public Slider SFXSlider;
    public Slider MusicSlider;
    public Slider MasterSlider;

    private void Start()
    {
        SFXLevel = PlayerPrefs.GetFloat("SFXVolume", 1);
        MusicLevel = PlayerPrefs.GetFloat("MusicVolume", 1);
        MasterLevel = PlayerPrefs.GetFloat("MasterVolume", 1);
        
        SFXSlider.value = SFXLevel;
        MusicSlider.value = MusicLevel;
        MasterSlider.value = MasterLevel;
        
        SetSFXVolume(SFXLevel);
        SetMusicVolume(MusicLevel);
        SetMasterVolume(MasterLevel);
    }

    public void SetSFXVolume(float value)
    {
        SolveConversion("SFXVolume", value);
        SFXLevel = value;
    }

    public void SetMusicVolume(float value)
    {
        SolveConversion("MusicVolume", value);
        MusicLevel = value;
    }

    public void SetMasterVolume(float value)
    {
        SolveConversion("MasterVolume", value);
        MasterLevel = value;
    }

    public void SolveConversion(string volumeParam, float value)
    {
        float delta;
        if (value > 0.001f) delta = Mathf.Log10(value) * multiplier;
        else delta = -80;
        mixer.SetFloat(volumeParam, delta);
        PlayerPrefs.SetFloat(volumeParam, value);
    }
}
