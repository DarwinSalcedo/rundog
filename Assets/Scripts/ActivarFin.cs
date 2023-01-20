using UnityEngine;
using System.Collections;

public class ActivarFin : MonoBehaviour {
	public GameObject CameraFin;
	public GameObject Cielo;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "fin");

	}
	
	
	void fin(Notification notificacion){
		Cielo.SetActive(true);
		CameraFin.SetActive(true);
	}

	//
	// Update is called once per frame
	void Update () {
		
	}
}
