using UnityEngine;
using System.Collections;

public class DestructorMonstruo : MonoBehaviour {

	private Animator animator;
	
	//	private bool corriendo = false;
	public float velocidad = 10f;
	void Awake(){
		animator = GetComponent<Animator>();
	}
	
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "correr");
	}
	
	void FixedUpdate(){
		
		//	if(corriendo){


	//	enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
	//	animator.SetBool("isGrounded", enSuelo);
	//	if(enSuelo){
		//		dobleSalto = false;
		//	}
		
	}

	void correr(Notification notificacion){
		rigidbody2D.velocity = new Vector2(velocidad , rigidbody2D.velocity.y);
		animator.SetFloat("VelX", rigidbody2D.velocity.x );
	}
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Player"){	
			//Debug.Break();
			NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeHaMuerto");
			// POR HACER... HACER QUE SE MUESTRE LA PUNTUACION MAXIMA
			// (HA MUERTO EL PERSONAJE)
		}
	}

}
	
	

