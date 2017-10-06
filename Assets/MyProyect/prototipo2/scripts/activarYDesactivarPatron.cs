using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class activarYDesactivarPatron : MonoBehaviour {

	public GameObject botonSeleccionado;
	public bool estadoBoton = true;

	void Start () {
		botonSeleccionado.SetActive (false);
	}
	
	// Update is called once per frame
	public void CambiarestadoDelBoton ()
	{
		if (estadoBoton == true) {
			botonSeleccionado.SetActive (true);
			estadoBoton = false; 
		} else if (estadoBoton == false ) {
			botonSeleccionado.SetActive (false);
			estadoBoton = true;
		}
	}
}
