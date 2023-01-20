using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {

	private bool haColisionadoConElJugador = false;
	public int puntosGanados = 100;
	public AudioClip itemSoundClip;
	public float itemSoundVolume = 1f;
	public GameObject hand;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}



	void OnCollisionEnter2D(Collision2D collision){
		if(!haColisionadoConElJugador && collision.gameObject.tag == "Player"){
			GameObject obj = collision.contacts[0].collider.gameObject;


			//Debug.Log("llegue aqui --- "+hola);
			//hola.SetActive(false);
			//Destroy(GameObject.Find("Ovni"));
			if(obj.name == "PataInferiorDerechaB" || obj.name == "PataInferiorIzquierdaB"){
				haColisionadoConElJugador = true;
				AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
				NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
				hand.SetActive(false);
			}
		}
	}
}
