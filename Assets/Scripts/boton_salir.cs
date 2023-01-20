using UnityEngine;
using System.Collections;

public class boton_salir : MonoBehaviour {
	
	public GUITexture boton;
	
	void Update () {
		if (Input.touchCount > 0) {
			for (int i = 0; i < Input.touchCount; i++) {
				Touch t = Input.GetTouch (i);
				if (t.phase == TouchPhase.Began) {
					if (boton.HitTest (t.position, Camera.main)) {
						Application.Quit();
					}
				}
			}
		}
	}
}


