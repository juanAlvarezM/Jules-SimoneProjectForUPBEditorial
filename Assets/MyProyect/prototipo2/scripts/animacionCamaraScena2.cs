using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionCamaraScena2 : MonoBehaviour {

	Animator anim;
	public GameObject BotonAnimacionAcercarce;
	public GameObject BotonAnimacion2;
	public GameObject BotonAnimacion3;
	public GameObject BotonAnimacion4;
	public GameObject BotonAnimacion5Retorno;
	public GameObject BotonCamara;
	public GameObject camara;
	public GameObject BotonesBloqueo; 
	public GameObject Mapa; 
	public GameObject Escanear;
	public float posicionx;
	public float posiciony;
	public float posicionz;



	void Start () {
		anim = GetComponent<Animator> ();
		BotonCamara.gameObject.SetActive (false);
		BotonesBloqueo.gameObject.SetActive (false);
		Mapa.gameObject.SetActive (false);
		Escanear.SetActive (false);
		camara.GetComponent<Transform> ();
	

	}

	// Update is called once per frame
	void Update () {

		posicionx = camara.GetComponent<Transform> ().position.x;
		posiciony = camara.GetComponent<Transform> ().position.y;
		posicionz = camara.GetComponent<Transform> ().position.z;

		if (posicionx == -2.8f && posiciony == -1.3f) {
			BotonesBloqueo.gameObject.SetActive (true);
			Mapa.gameObject.SetActive (true);
			//Escanear.gameObject.SetActive (true);
				
		} else {
			BotonesBloqueo.gameObject.SetActive (false);
			Mapa.gameObject.SetActive (false);
			Escanear.gameObject.SetActive (false);
		}
		if(posicionx == 2.7f && posiciony == -1.8f)
		{
			Escanear.gameObject.SetActive (true);
		}
		else{
			Escanear.gameObject.SetActive (false);
		}


	}

	public void PlayAnimation1 ()
	{
		anim.SetInteger ("PlayAnimacion", 1);
		BotonAnimacionAcercarce.gameObject.SetActive (false);
		BotonAnimacion2.gameObject.SetActive (true);

		/*	if(posicionx == -2.8 && posiciony == 2.7 && posicionz == -2.3 )
		{
			anim.SetInteger ("PlayAnimacion", 0);
		}
	*/
	}
	public void PlayAnimation2 ()
	{
		anim.SetInteger ("PlayAnimacion", 2);
		BotonAnimacion2.gameObject.SetActive (false);
		BotonAnimacion3.gameObject.SetActive (true);
		BotonAnimacion4.gameObject.SetActive (true);
		BotonCamara.gameObject.SetActive (true);
		BotonesBloqueo.gameObject.SetActive (true);
		Mapa.gameObject.SetActive (true);

		/*if(posicionx == -2.8 && posiciony == -1.3  && posicionz == -2.3)
		{
			BotonAnimacion3.gameObject.SetActive (true);
			Register.gameObject.SetActive (true);
		}*/

	}
	public void PlayAnimation2_2 ()
	{
		anim.SetInteger ("PlayAnimacion", 22);

	}

	public void PlayAnimation3 ()
	{
		anim.SetInteger ("PlayAnimacion", 3);
		BotonAnimacion3.gameObject.SetActive (false);
		BotonAnimacion4.gameObject.SetActive (false);
		BotonAnimacion5Retorno.gameObject.SetActive (true);
		BotonesBloqueo.gameObject.SetActive (false);
		Mapa.gameObject.SetActive (false);
	}
	public void PlayAnimation3_2 ()
	{
		anim.SetInteger ("PlayAnimacion", 32);
		BotonAnimacion4.gameObject.SetActive (false);
		BotonesBloqueo.gameObject.SetActive (false);
		Mapa.gameObject.SetActive (false);



	}
	public void PlayAnimation5Retorno ()
	{
		anim.SetInteger ("PlayAnimacion", 33);
		BotonAnimacion3.gameObject.SetActive (true);
		BotonAnimacion4.gameObject.SetActive (true);
		BotonAnimacion5Retorno.gameObject.SetActive (false);


	}

	public void PlayAnimation4 ()
	{
		anim.SetInteger ("PlayAnimacion", 4);
		BotonAnimacion4.gameObject.SetActive (false);



	}
	public void CambioPagina()
	{
		anim.SetInteger ("PlayAnimacion", 5);
	}

}
