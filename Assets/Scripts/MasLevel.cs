using UnityEngine;
using System.Collections;

public class MasLevel : MonoBehaviour {
	public int puntosGanados = 100;
	public GameObject Cielo;
	//public AudioClip itemSoundClip;
	//public float itemSoundVolume = 1f;



	// Use this for initialization
	void Start () {
		//NotificationCenter.DefaultCenter().AddObserver(this, "Noche");
	}



	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Player"){	
			Cielo.SetActive(false);
			NotificationCenter.DefaultCenter().PostNotification(this, "Noche");
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
			//AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
		}
		
		
	}



}
