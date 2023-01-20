using UnityEngine;
using System.Collections;

public class GeneradorSuelo : MonoBehaviour {
	
	public GameObject[] obj;

	
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
		
		

			Instantiate(obj[0], transform.position, Quaternion.identity);
			Invoke("Generar", 2);
		
		
		
	}
}
