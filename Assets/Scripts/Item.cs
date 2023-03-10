using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public int puntosGanados = 30;
	public AudioClip itemSoundClip;
	public float itemSoundVolume = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Player"){
			Destroy(gameObject);
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
			AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
		}


	}
}
