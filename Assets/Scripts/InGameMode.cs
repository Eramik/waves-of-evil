using UnityEngine;
using System.Collections;

public class InGameMode : MonoBehaviour {

    public ColorBlindFilter cameraMode;

    // Use this for initialization
    void Start () {
        cameraMode.mode = PlayerPrefs.GetInt("Mode");

    }
	
}
