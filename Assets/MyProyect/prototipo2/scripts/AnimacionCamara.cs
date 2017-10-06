using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AnimacionCamara : MonoBehaviour {

	Animator anim;
	public GameObject BotonAnimacionAcercarce;
	public GameObject BotonAnimacionRegistro;
	public GameObject BotonAnimacionSellecionAInicioSesion;
	public GameObject BotonAnimacion3;
	public GameObject BotonAnimacion4;
	public GameObject Register;
	public GameObject Login;
	public GameObject camara;
	public GameObject botonesPatron;
	public GameObject CambioDePagina;
	public float posicionx;
	public float posiciony;
	public float posicionz;

	// User data

	public InputField Username; 
	public InputField Email;
	public InputField Password;
	public InputField ConfPassword; 

	public InputField txtUsername;


	void Start () {
		anim = GetComponent<Animator> ();
		camara.GetComponent<Transform> ();
		botonesPatron.gameObject.SetActive (false);
		CambioDePagina.gameObject.SetActive (false);


		//DontDestroyOnLoad (gameObject);
	}

	// Update is called once per frame
	void Update () {		
		posicionx = camara.GetComponent<Transform> ().position.x;
		posiciony = camara.GetComponent<Transform> ().position.y;
		posicionz = camara.GetComponent<Transform> ().position.z;


		//aparecen botones de registro
		if (posicionx == -2.8f && posiciony == -1.3f) {
			Debug.Log ("Entrando al if ");
			Register.gameObject.SetActive (true);
		} else {
			
			Register.gameObject.SetActive (false);
		}

		//aparecen los botnoes de login 
		if(posicionx == 1.9f && posiciony == 3.2f)
		{
			Login.gameObject.SetActive (true);
		}
		else{
			Login.gameObject.SetActive (false);
		}

		// aparece el patron y boton entrar que cambia de escena

		if (posicionx == 2.7f && posiciony == -1.8f) {
			botonesPatron.gameObject.SetActive (true);
			CambioDePagina.gameObject.SetActive (true);
		} else {
			botonesPatron.gameObject.SetActive (false);
			CambioDePagina.gameObject.SetActive (false);
		}
			

	}

	//animacion para ir a el comienzo (Nuevo viajero, Iniciar Viaje)
	public void PlayAnimation1 ()
	{
		anim.SetInteger ("PlayAnimacion", 1);
		BotonAnimacionAcercarce.gameObject.SetActive (false);
		BotonAnimacionRegistro.gameObject.SetActive (true);
		BotonAnimacionSellecionAInicioSesion.gameObject.SetActive (true);
	/*	if(posicionx == -2.8 && posiciony == 2.7 && posicionz == -2.3 )
		{
			anim.SetInteger ("PlayAnimacion", 0);
		}
	*/
	}

	//animacion ara ir a registarse.
	public void PlayAnimation2 ()
	{
		
		anim.SetInteger ("PlayAnimacion", 2);
		BotonAnimacionSellecionAInicioSesion.gameObject.SetActive (false);
		BotonAnimacionRegistro.gameObject.SetActive (false);

	}
	public void PlayAnimation2_2 ()
	{
		anim.SetInteger ("PlayAnimacion", 22);
		BotonAnimacionRegistro.gameObject.SetActive (false);
		BotonAnimacionSellecionAInicioSesion.gameObject.SetActive (false);
		Login.gameObject.SetActive (true);
	}

	public void PlayAnimation3 ()
	{
		//PlayerPrefs.SetString ("Username", Username.text );
		//string unse = PlayerPrefs.GetString ("Username");
		//txtUsername.text = PlayerPrefs.GetString("Username");
		anim.SetInteger ("PlayAnimacion", 3);
		BotonAnimacion3.gameObject.SetActive (false);
		Register.gameObject.SetActive (false);
		//BotonAnimacion4.gameObject.SetActive (true);
		//Login.gameObject.SetActive (true);

	}

	public void PlayAnimation4 ()
	{
		anim.SetInteger ("PlayAnimacion", 4);
		BotonAnimacion4.gameObject.SetActive (false);
		Login.gameObject.SetActive (false);
		//botonesPatron.gameObject.SetActive (true);
		//CambioDePagina.gameObject.SetActive (true);


	}
	public void CambioPagina()
	{
		anim.SetInteger ("PlayAnimacion", 5);
		Debug.Log ("Acá se llama la animación cambio de pagina");

	}
		
}
