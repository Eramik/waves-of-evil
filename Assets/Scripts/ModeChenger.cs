using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ModeChenger : MonoBehaviour {

    public ColorBlindFilter cameraMode;

    



    // Update is called once per frame
    void Update () {
        PlayerPrefs.SetInt("Mode", GetComponent<Dropdown>().value);

        cameraMode.mode = PlayerPrefs.GetInt("Mode");
	
	}

    
}
