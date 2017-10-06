﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {
	public GameObject username;
	public GameObject password;
	private string Username;
	private string Password;
	private string[] Lines; 
	private string DecryptedPass;

	public void LoginButton()
	{
		bool UN = false;  // UN es username 
		bool PW = false; // paswword

		if(Username != "")
		{
			if (!System.IO.File.Exists (@"D:/UnityTestFolder/" + Username + ".txt")) {
				UN = true;
				Lines = System.IO.File.ReadAllLines(@"D:/UnityTestFolder/" + Username + ".txt");
			} else {
				Debug.LogWarning ("Username Invalid");
			}
		} else {
			Debug.LogWarning ("Username Field Empty");
		}
		if (Password != "") {
			if (!System.IO.File.Exists (@"D:/UnityTestFolder/" + Username + ".txt")) {
				int i = 1;
				foreach (char c in Lines[2]) {
					i++;
					char Decrypted = (char)(c / i);
					DecryptedPass += Decrypted.ToString();
				}
				if (Password == DecryptedPass) {
					PW = true;
				}else {
					Debug.LogWarning ("Password Is Invalid");
				}
			}else {
				Debug.LogWarning ("Password Is invalid");
			}

		} else {
			Debug.LogWarning ("Password Field Empty");
		}
		if(UN == true && PW == true)
		{
			username.GetComponent<InputField> ().text = "";
			password.GetComponent<InputField> ().text = "";
			Debug.Log ("Login Succesful");
			SceneManager.LoadScene ("Patron");
		}

	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			if (username.GetComponent<InputField> ().isFocused) {
				password.GetComponent<InputField> ().Select ();
			}
		}
		if (Input.GetKeyDown (KeyCode.Return)) {
			if (Password != "" && Password != "") {
				LoginButton ();
			}
		}
		Username = username.GetComponent<InputField> ().text;
		Password = password.GetComponent<InputField> ().text;
	}
}
