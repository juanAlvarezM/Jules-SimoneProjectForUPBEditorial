using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barco : MonoBehaviour {
	public GameObject Disparador;
	public Transform Torpedo; 
	public Rigidbody TorpedoRigidbody;
	Vector3 posicionDisparador = new Vector3(); 
	Rigidbody clone;

	void Start () {
		posicionDisparador = Disparador.GetComponent<Transform> ().position;
	}
	

	void Update () {
		clone.AddForce (100,0,0);
	}

	public void Disparar ()
	{
		clone = Instantiate (TorpedoRigidbody, posicionDisparador, Quaternion.identity); 

	}
}
