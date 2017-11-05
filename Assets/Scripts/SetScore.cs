using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetScore : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();
    }
}
