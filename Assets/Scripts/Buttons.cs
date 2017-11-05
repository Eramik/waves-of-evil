using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

    public string action;
    public GameObject score;
    public GameObject settings;

    void OnMouseDown()
    {
        
        if (action == "Quit")
            Application.Quit();
        if (action == "Play")
        {
            //PlayerPrefs.DeleteAll();
            Application.LoadLevel(1);
        }
        if (action == "Score")
        {
            score.SetActive(true);
        }
        if (action == "Set")
        {
            settings.SetActive(true);
        }
    }
}
