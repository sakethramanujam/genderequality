using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Sprite musicOn;
    public Sprite musicOff;
    public GameObject musicImage;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onPlayClick()
    {
        Application.LoadLevel("GenderEquality");
    }

    public void creditBack()
    {
        Application.LoadLevel("MainMenu");
    }

    public void creditClick()
    {
        Application.LoadLevel("Credits");
    }

    public void helpClick()
    {
        Application.LoadLevel("Help");
    }

    public void helpBack()
    {
        Application.LoadLevel("MainMenu");
    }

    public void onMusicClick()
    {
        if(musicImage.GetComponent<Image>().sprite==musicOn)
        {
            musicImage.GetComponent<Image>().sprite = musicOff;
        }

        else

        {
            musicImage.GetComponent<Image>().sprite = musicOn;
        }
    }
}
