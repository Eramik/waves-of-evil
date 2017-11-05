using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
    int cheker = 2;
    public GameObject enemy;
    public int count = 5;
    private float spawnCounter;
    public float timeBetweenSpawns;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if(count >= 0)
        {
            Instantiate(enemy, new Vector3(Random.Range(-20, 20), 2.18f, transform.position.z), Quaternion.identity);
            count--;
        }
        spawnCounter -= Time.deltaTime;
        if (spawnCounter <=0)
        {
            spawnCounter = timeBetweenSpawns;
            cheker = cheker + 1;
            count = cheker;
        }
    }
}
