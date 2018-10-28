using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionFix : MonoBehaviour {

    private void Awake()
    {
        //Set screen size for Standalone
#if UNITY_STANDALONE
        Screen.SetResolution( 608, 1080 , false);
        Screen.fullScreen = false;
#endif
    }
}
