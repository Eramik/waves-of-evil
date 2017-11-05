using UnityEngine;
using System.Collections;

public class SmoothCam : MonoBehaviour {
    public Transform target;
    public Vector3 ofset;
    // Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
        if (target)
        {

            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f)+ofset;
        }
    }
}
