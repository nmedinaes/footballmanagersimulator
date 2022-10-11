using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class optionsMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void pantallaCompleta(bool isActive)
    {
        Screen.fullScreen = isActive;
    }

    public void cambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }

    public void cambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
