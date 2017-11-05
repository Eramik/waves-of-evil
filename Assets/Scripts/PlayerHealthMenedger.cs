using UnityEngine;
using System.Collections;

public class PlayerHealthMenedger : MonoBehaviour {

    public int startingHealth;
    public int currentHealth;
    public int damageToGive;
    public GameObject die;
    // Use this for initialization
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            
                if(PlayerPrefs.GetInt("Score") < PlayerPrefs.GetInt("Game"))
                    PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Game"));
            die.SetActive(true);
            Application.LoadLevel(0);
        }
    }

    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("vgdfvg");
        if (other.gameObject.tag == "Enemy")
        {
            HurtPlayer(damageToGive);

            Destroy(other.gameObject);
        }
    }
}
