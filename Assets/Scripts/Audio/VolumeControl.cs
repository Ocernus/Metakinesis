using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public string volumeParam = "MasterVolume";
    public AudioMixer mixer;
    public Slider slider;
    private float multiplier = 30f;

    private void Awake()
    {        
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volumeParam, slider.value);
    }

    private void HandleSliderValueChanged(float value)
    {
        if (value > 0.001f) mixer.SetFloat(volumeParam, Mathf.Log10(value) * multiplier);
        else mixer.SetFloat(volumeParam, -80);
    }

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat(volumeParam, slider.value);
    }
}
