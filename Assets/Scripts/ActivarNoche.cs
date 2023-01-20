using UnityEngine;
using System.Collections;

public class ActivarNoche : MonoBehaviour {
	public GameObject CameraOscura;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "Noche");
		NotificationCenter.DefaultCenter().AddObserver(this, "Dia");
	}

	
	void Noche(Notification notificacion){
		CameraOscura.SetActive(true);
	}
	void Dia(Notification notificacion){
		CameraOscura.SetActive(false);
	}
	//
	// Update is called once per frame
	void Update () {
	
	}
}
