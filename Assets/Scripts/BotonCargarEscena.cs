using UnityEngine;
using System.Collections;

public class BotonCargarEscena : MonoBehaviour {

	public string nombreEscenaParaCargar = "GameScene";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
		//	Camera.main.audio.Stop();
		//	audio.Play();
		//	Invoke("CargarNivelJuego", audio.clip.length);	
			CargarNivelJuego();	
		}
	
	}
	
	void CargarNivelJuego(){
		Application.LoadLevel(nombreEscenaParaCargar);
	}
}
