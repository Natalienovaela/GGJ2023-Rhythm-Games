using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    [Header("Volume Setting")]
    [SerializeField] private Slider volumeSlider = null;

    [Header("SFX Setting")]
    [SerializeField] private Slider sfxSlider = null;

    [Header("Scene To Load")]
    public string _newScene;

    float Selection;

    [Space(10)]
    [Header("Music")]
    public GameObject MusicSprite;
    public GameObject MusicSpriteSelected;

    [Space(10)]
    [Header("Sound")]
    public GameObject SoundSprite;
    public GameObject SoundSpriteSelected;

    void Start()
    {
        Selection = 1;
        MusicSpriteSelected.SetActive(false);
        SoundSpriteSelected.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Selection++;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Selection--;
        }

        if(Selection%2 != 0)
        {
            SoundSpriteSelected.SetActive(false);
            MusicSpriteSelected.SetActive(true);
        }
        if(Selection%2 == 0)
        {
            MusicSpriteSelected.SetActive(false);
            SoundSpriteSelected.SetActive(true);
            
        }
    }

    public void buttonClicked()
    {
        SceneManager.LoadScene(_newScene);
    }

    /*public void back()
    {
        
    }*/

    public void setVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
    }

    public void SetSound(float volume)
    {
        AudioListener.volume = volume;
    }

    public void SoundApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
    }



}
