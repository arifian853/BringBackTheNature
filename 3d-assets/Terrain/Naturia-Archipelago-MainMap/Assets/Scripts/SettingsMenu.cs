using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer mainMixer;
    public void SetVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }

    public void SetFullscreen(bool fullscreen)
    {
        if (fullscreen)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
        else {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
            
    }

    public void SetQuality(int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
    }

}
