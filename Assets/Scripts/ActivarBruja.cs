using UnityEngine;
using System.Collections;

public class ActivarBruja : MonoBehaviour {
	public GameObject obj;

	// Use this for initialization
	void Start () {
		//objAux.SetActive (true);
		//	obj.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Player"){	
			NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeEmpiezaACorrerBruja");
				obj.SetActive(true);
		}
	}
}
