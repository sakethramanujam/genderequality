using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private GameObject Source;
    public AudioClip GoalClip;
    public AudioClip PersonClip;
    public GameObject PlayerManager;
    private void Start()
    {
        Source = this.gameObject;
    }
    void Update ()
    {
		if(Input.GetKeyDown("q"))
        {
            PlayerManager.GetComponent<PlayerManager>().femaleIncrement();
            Source.GetComponent<AudioSource>().PlayOneShot(PersonClip, .5f);
        }
        if (Input.GetKeyDown("w"))
        {
            PlayerManager.GetComponent<PlayerManager>().femaleDecrement();
            Source.GetComponent<AudioSource>().PlayOneShot(PersonClip, .5f);
        }
        if (Input.GetKeyDown("e"))
        {
            PlayerManager.GetComponent<PlayerManager>().femaleGoalIncrement();
            Source.GetComponent<AudioSource>().PlayOneShot(GoalClip, .5f);
        }
        if (Input.GetKeyDown("r"))
        {
            PlayerManager.GetComponent<PlayerManager>().femaleGoalDecrement();
            Source.GetComponent<AudioSource>().PlayOneShot(GoalClip, .5f);
        }
        if (Input.GetKeyDown("u"))
        {
            PlayerManager.GetComponent<PlayerManager>().maleGoalIncrement();
            Source.GetComponent<AudioSource>().PlayOneShot(GoalClip, .5f);
        }
        if (Input.GetKeyDown("i"))
        {
            PlayerManager.GetComponent<PlayerManager>().maleGoalDecrement();
            Source.GetComponent<AudioSource>().PlayOneShot(GoalClip, .5f);
        }
        if (Input.GetKeyDown("o"))
        {
            PlayerManager.GetComponent<PlayerManager>().maleDecrement();
            Source.GetComponent<AudioSource>().PlayOneShot(PersonClip, .5f);
        }
        if (Input.GetKeyDown("p"))
        {
            PlayerManager.GetComponent<PlayerManager>().maleIncrement();
            Source.GetComponent<AudioSource>().PlayOneShot(PersonClip, .5f);
        }
    }
}
