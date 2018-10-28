using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Button_sounds : MonoBehaviour {
    public AudioClip sound;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource Source { get { return GetComponent<AudioSource>(); } }
    // Use this for initialization
    void Start () {
        gameObject.AddComponent<AudioSource>();
        Source.clip = sound;
        Source.playOnAwake = false;
        button.onClick.AddListener(() => playSound());
	}
	
	// Update is called once per frame
	void playSound () {
        Source.PlayOneShot(sound);
	}
}
