using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour {

	public GameObject LighterObject=null;
	
	// Update is called once per frame
	void Update () {
		float sysHours = System.DateTime.Now.Hour;	
		if (sysHours >= 18f || sysHours <= 6f)
			LighterObject.SetActive (true);
		else
			LighterObject.SetActive (false);
	}
}
