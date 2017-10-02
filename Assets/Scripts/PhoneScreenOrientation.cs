using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneScreenOrientation : MonoBehaviour {

    void Start() {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
		Screen.SetResolution(1920, 1080, true);
    }
	
}
