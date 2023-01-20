using UnityEngine;
using System.Collections;

public class Jugar : MonoBehaviour {
	public CircleCollider2D presionar;
	public string nombreEscenaParaCargar = "GameScene";
	
	// Use this for initialization
	void Start () {
		presionar = this.gameObject.GetComponent<CircleCollider2D>();
		//personaje = this.transform.parent.gameObject.GetComponent<PersonajeScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		tocandoPantalla ();
	}
	
	private void tocandoPantalla(){
		
		if ( Input.GetMouseButtonDown (0)) {
			//Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 posicionTap2D = new Vector2 (posicionTap.x, posicionTap.y);
			bool presiono = presionar.OverlapPoint (posicionTap2D);
			if (presiono) {
				Debug.Log("cargar escena de juego 1");
				Application.LoadLevel(nombreEscenaParaCargar);
				
				
			}
			
		}
		
	}
}
