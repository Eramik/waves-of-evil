using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    private Rigidbody myRB;
    public float moveSpeed;

    public PlayerController thePlayer;
    public WaveController antena;
    public GameObject locateWawes;
    public float visibleDistance;
    public GameObject model;
    public float lifeTime;

    // Use this for initialization
    void Start () {
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
        antena = FindObjectOfType<WaveController>();
    }

    void FixedUpdate()
    {
        myRB.velocity = (transform.forward * moveSpeed);
    }
	
	// Update is called once per frame
	void Update () {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }

        transform.LookAt(thePlayer.transform.position);
        if(Vector3.Distance(thePlayer.transform.position, transform.position) <= visibleDistance)
        {
            model.SetActive(true);
        }

        if ((Input.GetKey(KeyCode.E) || (Input.GetKey(KeyCode.JoystickButton6))))
        {
            antena.isWaving = true;
            locateWawes.SetActive(true);
        }
        else
        {
            antena.isWaving = false;
            locateWawes.SetActive(false);
        }

	}
}
