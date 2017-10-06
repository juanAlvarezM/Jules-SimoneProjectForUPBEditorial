using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ReproductorVideoscena2: MonoBehaviour {
	public GameObject contenedorCamara; 
	public Camera camara;
	public GameObject LibroAbierto; 
	public GameObject Patron; 
	public GameObject Patron2; 
	public GameObject Patron3; 
	public GameObject Patron4; 
	public GameObject BotonAnimacion1;
	public GameObject BotonAnimacion2;
	public GameObject BotonAnimacion3;
	public GameObject BotonAnimacion4;
	public GameObject BotonAnimacion5Retorno;

	void Awake()
	{

		camara = Camera.main;

	}

	// videoPlayer.Play();

	void Start () {
		LibroAbierto.gameObject.SetActive (true);
		// los patrones son las imagenes del libro 
		Patron.gameObject.SetActive (true);
		Patron2.gameObject.SetActive (true);
		Patron3.gameObject.SetActive (true);
		Patron4.gameObject.SetActive (true);
		//El botón que al darle click se activa la animación
		BotonAnimacion1.gameObject.SetActive (true); 
		BotonAnimacion2.gameObject.SetActive (false);
		BotonAnimacion3.gameObject.SetActive (false); 
		BotonAnimacion4.gameObject.SetActive (false); 
		BotonAnimacion5Retorno.gameObject.SetActive (false); 


	}

	// Update is called once per frame
	void Update () {

	}





}
