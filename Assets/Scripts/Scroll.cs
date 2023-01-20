using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public bool IniciarEnMovimiento = false;
	public float velocidad = 0f;
	private bool enMovimiento = false;
	private float tiempoInicio = 0f;
	//public Transform personaje;
	// Use this for initialization
	void Start () {


		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeFin");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
		if (IniciarEnMovimiento) {
			PersonajeEmpiezaACorrer();
		}
	}

	void PersonajeHaMuerto(){
		enMovimiento = false;
		NotificationCenter.DefaultCenter().PostNotification(this, "quitar");
		tiempoInicio = 0f;
		//personaje.gameObject.SetActive (false);
	}

	void PersonajeEmpiezaACorrer(){
		enMovimiento = true;
		tiempoInicio =  Time.time;
		Debug.Log (" tiempoInicio " + tiempoInicio );
	}
	void PersonajeFin(){
		enMovimiento = false;
		tiempoInicio = 0f;
		NotificationCenter.DefaultCenter().PostNotification(this, "Dia");
	}
	
	// Update is called once per frame
	void Update () {
		if(enMovimiento){
			renderer.material.mainTextureOffset = new Vector2(((Time.time - tiempoInicio) * velocidad) % 1, 0);
		}
	}
}
