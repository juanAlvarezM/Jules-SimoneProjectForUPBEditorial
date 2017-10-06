using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ReproductorVideos : MonoBehaviour {
	public GameObject contenedorCamara; 
	public Camera camara; 
	public GameObject videoIntro1; 
	public GameObject videoIntro2; 
	public VideoPlayer videoPlayer;
	public VideoPlayer videoPlayer2;
	public GameObject BotonAbreme; 
	public GameObject LibroAbierto; 
	public GameObject Patron; 
	public GameObject Patron2; 
	public GameObject Patron3; 
	public GameObject Patron4; 
	public GameObject BotonAnimacion1;
	public GameObject BotonAnimacion2;
	public GameObject BotonAnimacion2_2;
	public GameObject BotonAnimacion3;
	public GameObject BotonAnimacion4;
	public GameObject Register;
	public GameObject Login;

	private bool video2Activo = false;

	void Awake()
	{

		camara = Camera.main;
		videoPlayer.GetComponent<VideoPlayer>(); 
		videoPlayer2.GetComponent<VideoPlayer> ();
	}

	// videoPlayer.Play();

	void Start () {
		videoIntro1.gameObject.SetActive (true);
		videoIntro2.gameObject.SetActive (false);
		LibroAbierto.gameObject.SetActive (false);
		// los patrones son las imagenes del libro 
		Patron.gameObject.SetActive (false);
		Patron2.gameObject.SetActive (false);
		Patron3.gameObject.SetActive (false);
		Patron4.gameObject.SetActive (false);
		//El botón que al darle click se activa la animación
		BotonAnimacion1.gameObject.SetActive (false); 
		BotonAnimacion2.gameObject.SetActive (false);
		BotonAnimacion2_2.gameObject.SetActive (false); 
		BotonAnimacion3.gameObject.SetActive (false); 
		BotonAnimacion4.gameObject.SetActive (false); 
		Register.gameObject.SetActive(false);
		Login.gameObject.SetActive(false);


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void cambioVideo()
	{
		videoIntro2.gameObject.SetActive (true);
		videoIntro1.gameObject.SetActive (false);
		BotonAbreme.SetActive (false);
		video2Activo = true;

		if( video2Activo == true)
		{
			BotonAnimacion1.gameObject.SetActive (true); 
		}
	}

	public void quitarVideo2()
	{
		LibroAbierto.gameObject.SetActive (true);
		videoIntro2.gameObject.SetActive (false);
		videoIntro1.gameObject.SetActive (false);
		Patron.gameObject.SetActive (true);
		Patron2.gameObject.SetActive (true);
		Patron3.gameObject.SetActive (true);
		Patron4.gameObject.SetActive (true);

	}



}
