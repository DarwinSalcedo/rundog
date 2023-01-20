using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {
	
	public Transform personaje;
	public float separacion;
	private bool enMovimiento = false;
	void Start () {
		
		
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
	
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");

	}
	// Update is called once per frame
	void Update () {
				if (enMovimiento) {
						transform.position = new Vector3 (personaje.position.x + separacion, transform.position.y, transform.position.z);
				}
		}

	void PersonajeHaMuerto(){
		enMovimiento = false;	
		personaje.gameObject.SetActive (false);
	}
	void PersonajeEmpiezaACorrer(){
		enMovimiento = true;
	}
}

