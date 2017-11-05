using UnityEngine;
using System.Collections;

public class WaveController : MonoBehaviour {

    public bool isWaving;
    public GameObject antenaWave;


	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
        if (isWaving)
        {
            antenaWave.SetActive(true);
        }
        else
        {
            antenaWave.SetActive(false);
        }
	}
}
