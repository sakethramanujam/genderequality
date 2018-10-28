using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDes : MonoBehaviour
{
    public static DontDes instance;
    private void Awake()
    {
        if(instance)
        {
            Destroy(this.gameObject);

        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.loadedLevel == 1)
        {
            this.GetComponent<AudioSource>().volume = 0;
        }

        else
        {
            this.GetComponent<AudioSource>().volume = 1;
        }
    }
}
