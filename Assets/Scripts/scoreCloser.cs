using UnityEngine;
using System.Collections;

public class scoreCloser : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }
    }
}
