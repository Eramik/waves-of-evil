using UnityEngine;
using System.Collections;

public class EnemyHealthMenedger : MonoBehaviour {

    public int health;
    private int currentHealth;


	// Use this for initialization
	void Start () {
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
	    if(currentHealth <= 0)
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("Game", PlayerPrefs.GetInt("Game") + 1);
        }
	}

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }
}
