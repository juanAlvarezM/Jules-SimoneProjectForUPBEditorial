using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenas : MonoBehaviour {

	public void CambiarEscena(string Nombre)
	{
		Debug.Log ("Cambiando Escena" + Nombre);
		SceneManager.LoadScene (Nombre);
	}
	public void IrAPaginaWeb ()
	{
		Debug.Log ("Llendo a página web");
	}
	public void Salir() 
	{
		Debug.Log ("Saliendo del Juego");
		Application.Quit ();
	}

}
