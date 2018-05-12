using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    public  AudioMixer audioMixer;
    public Slider VolumeSlider;

    public void SetVolume (float volume) {

        audioMixer.SetFloat("Volume", volume);

    }
    public void ResetVolume () {
        
         VolumeSlider.value = 0;

    }
  



}
