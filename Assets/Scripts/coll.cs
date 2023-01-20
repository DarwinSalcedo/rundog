using UnityEngine;
using System.Collections;

public class coll : MonoBehaviour {
	private bool haColisionadoConElJugador = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
	if(!haColisionadoConElJugador && collision.gameObject.tag == "Player"){
		GameObject obj = collision.contacts[0].collider.gameObject;

		
			if(obj.name == "PataInferiorDerechaA" || obj.name == "Cabeza" || obj.name == "PataInferiorIzquierdaB"){
			haColisionadoConElJugador = true;
			//AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
			//NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
				NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeHaMuerto");
				//Debug.Break();
		}
	}
}
}
