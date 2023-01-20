using UnityEngine;
using System.Collections;

public class ActivarSalto : MonoBehaviour {
	public AudioClip itemSoundClip;
	public float itemSoundVolume = 1f;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "Saltar");
	}
	
	// Update is called once per frame
	void Update () {

	}
	void Saltar(){
		AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
	}
}
