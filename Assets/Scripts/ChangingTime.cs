using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float sysHour = System.DateTime.Now.Hour;
		float sysMin = System.DateTime.Now.Minute;
		transform.rotation = Quaternion.Euler (-90f - (sysHour * 60f + sysMin) * 0.25f, 0f, 0f);
		//transform.rotation.x = -90 - (sysHour * 60 + sysMin) * 0.25;
	/*	transform.rotation.x = -90f - (sysHour * 60f + sysMin) * 0.25f;
		if (sysHour == 0) {
			if (sysMin == 0) {
				transform.rotation.x = -90f;
			}
		}*/
	}
}
