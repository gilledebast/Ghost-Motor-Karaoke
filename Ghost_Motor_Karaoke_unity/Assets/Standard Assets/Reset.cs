﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	void Start () {}
	
	void Update () {

		//USE "r" FOR RESETING THE ACTIVE SCENE
		if (Input.GetKey ("r")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
