using UnityEngine;
using System.Collections;

public class Bruja : MonoBehaviour {
	public Transform personaje;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeEmpiezaACorrerBruja");
		
	}
	
	void PersonajeEmpiezaACorrerBruja(Notification notficacion){
		Generar();
	}

	void Generar(){
		 float altura = 0;
		if (transform.position.y < 5) {
			altura = transform.position.y + Random.Range(0,6);}
		// a.position = new Vector3(transform.position.x+1, transform.position.y, transform.position.z);
		transform.position = new Vector3 (personaje.position.x + Random.Range(0,15), altura, transform.position.z);
		//transform.rotation = new Vector3 (personaje.position.x + Random.Range(0,10), transform.position.y , transform.position.z);

		Invoke("Generar", 5);
	}
}
