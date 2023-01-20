using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
	
	public GameObject[] obj;
	public float tiempoMin = 1.25f;
	public float tiempoMax = 2.5f;
	//public Transform a;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeEmpiezaACorrer");

	}

	void PersonajeEmpiezaACorrer(Notification notficacion){
		Generar();
	}
	// Update is called once per frame
	void Update () {

	}
	
	void Generar(){
	    // a.position = new Vector3(transform.position.x+1, transform.position.y, transform.position.z);
		Instantiate(obj[Random.Range(0,obj.Length)], transform.position, Quaternion.identity);
		Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
	}
}
