using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeDisplayText : MonoBehaviour
{
    public Slider VolumeSlider;

    // Use this for initialization
    void Start()
    {
        Text sliderValue = GetComponent<Text>();
        sliderValue.text = VolumeSlider.value.ToString("0");

    }

    // Update is called once per frame
    public void Update()
    {
        Text sliderValue = GetComponent<Text>();
        sliderValue.text = VolumeSlider.value.ToString("0");

    }
    public void VolumeChanged()
    {
        Text sliderValue = GetComponent<Text>();
        sliderValue.text = VolumeSlider.value.ToString("0");

    }

}
