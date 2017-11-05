using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetGameScore : MonoBehaviour {
    public bool isDead;

    void Start()
    {
        PlayerPrefs.SetInt("Game", 0);
    }

	// Update is called once per frame
	void Update () {
        if (isDead)
        {
            
                PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Game"));
                //PlayerPrefs.SetInt("Game", 0);
        }
        GetComponent<Text>().text = PlayerPrefs.GetInt("Game").ToString();
	}
}
