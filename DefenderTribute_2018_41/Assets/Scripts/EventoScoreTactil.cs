﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EventoScoreTactil : MonoBehaviour {


	[SerializeField] Animator scrollAnim;
	[SerializeField] InicializarPuntuaciones inicializarPuntuaciones;
	[SerializeField] int escena;
	[SerializeField] float velocidadAnim;

	// Use this for initialization	
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Tocando () {

		if (inicializarPuntuaciones.terminado) {

			SceneManager.LoadScene(escena);
			//Application.LoadLevel (escena);

		} else {

			scrollAnim.speed = velocidadAnim;
		
		}
	}
	public void NoTocando () {

			scrollAnim.speed = 1;

	}
}
