using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public float speed = 40;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if ( Input.GetMouseButtonDown(0) )
        {
            GameObject b =  GameObject.Instantiate( bullet, transform.position, transform.rotation );
            Rigidbody rgb = b.GetComponent<Rigidbody>();
            rgb.velocity = transform.forward * speed;
        }

	}
}
