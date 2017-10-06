using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiburon : MonoBehaviour {
	public Rigidbody tiburon; 
	// Use this for initialization
	void Start () {
		tiburon.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		tiburon.AddForce (00,0,0);
	}
}
