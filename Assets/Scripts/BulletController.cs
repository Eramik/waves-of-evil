using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public int damageToGive;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyHealthMenedger>().HurtEnemy(damageToGive);
            Destroy(gameObject);
        }
    }
}
