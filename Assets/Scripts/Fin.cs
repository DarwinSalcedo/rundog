using UnityEngine;
using System.Collections;

public class Fin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Generara () {
		NotificationCenter.DefaultCenter().PostNotification(this, "fin");
	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Player"){	
			
			NotificationCenter.DefaultCenter().PostNotification(this, "Dia");
			NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeFin");
			NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeParar");
			Camera.main.audio.Stop ();
			Invoke("Generara", 2);

			//AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
		}
		if(collider.tag == "Zombie" ){
			Destroy(gameObject);
		}

}
}