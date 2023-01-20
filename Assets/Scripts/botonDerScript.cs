using UnityEngine;
using System.Collections;

public class botonDerScript : MonoBehaviour {
	
	//private PersonajeScript personaje;
	public CircleCollider2D presionar;
	public TextMesh marcador;
	
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
		marcador.text = " ";
		presionar.gameObject.SetActive (false);
	}
	private void tocandoPantalla(){
	
		if ( Input.GetMouseButtonDown (0)) {
			//Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 posicionTap2D = new Vector2 (posicionTap.x, posicionTap.y);
			bool presiono = presionar.OverlapPoint (posicionTap2D);
			if (presiono) {
				marcador.text = "pause";
				Time.timeScale = 1.0f - Time.timeScale;
				Time.fixedDeltaTime = 0.02f * Time.timeScale;
				GUI.backgroundColor = Color.black;


		}
			
	}

	}}