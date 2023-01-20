using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {

	public GameObject camaraGameOver;
	public GameObject botonVolver;
	public AudioClip gameOverClip;
	public GameObject menu;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
	}
	
	void PersonajeHaMuerto(Notification notificacion){
		NotificationCenter.DefaultCenter().PostNotification(this,"Dia");
		Camera.main.audio.Stop ();
		audio.clip = gameOverClip;
		audio.loop = false;
		audio.Play();
		menu.SetActive(true);
		botonVolver.SetActive(true);
		camaraGameOver.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
