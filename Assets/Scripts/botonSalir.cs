using UnityEngine;
using System.Collections;

public class botonSalir : MonoBehaviour {

	//private PersonajeScript personaje;
	public CircleCollider2D presionar;

	
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "quitar");
		presionar = this.gameObject.GetComponent<CircleCollider2D>();
		//personaje = this.transform.parent.gameObject.GetComponent<PersonajeScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		tocandoPantalla ();
	}
	void quitar (Notification notificacion){

		//presionar.gameObject.SetActive (false);
	}
	private void tocandoPantalla(){
		
		if ( Input.GetMouseButtonDown (0)) {
			//Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 posicionTap2D = new Vector2 (posicionTap.x, posicionTap.y);
			bool presiono = presionar.OverlapPoint (posicionTap2D);
			if (presiono) {
				Application.Quit();
				Debug.Log("presiono salir");
				
			}
			
		}
		
	}
}
