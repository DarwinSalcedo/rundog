using UnityEngine;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {

	public float fuerzaSalto = 100f;

	private bool enSuelo = true;
	public Transform comprobadorSuelo;
	public float comprobadorRadio = 0.7f;
	public LayerMask mascaraSuelo;
	public GameObject  refrescar ;
	public GameObject  refrescarDos ;
	private bool dobleSalto = false;

	private Animator animator;

	private bool corriendo = false;
	public float velocidad = 7f;
	void Awake(){
		animator = GetComponent<Animator>();

		float	tiempo = Time.timeScale ;
		Debug.Log (" time " + tiempo );
		if (tiempo == 0) {
			Camera.main.audio.Stop ();

			refrescar.SetActive(true);
			Debug.Log (" cargar "  );
		}else{

			refrescarDos.SetActive(true);
		}
	}

	// Use this for initialization
	void Start () {
//		Time.deltaTime =	 Time.fixedDeltaTime  ;
	
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeParar");
	}

	void PersonajeParar(){
		corriendo = false;
		velocidad = 0f;
	}
	void FixedUpdate(){

		if(corriendo){
			rigidbody2D.velocity = new Vector2(velocidad , rigidbody2D.velocity.y);
		}
		animator.SetFloat("VelX", rigidbody2D.velocity.x );
		enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		animator.SetBool("isGrounded", enSuelo);
		if(enSuelo){
			dobleSalto = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if(corriendo){				
				if((enSuelo || !dobleSalto)){
					rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, fuerzaSalto);
					//rigidbody2D.AddForce(new Vector2(0, fuerzaSalto));
					NotificationCenter.DefaultCenter().PostNotification(this,"Saltar");
					if(!dobleSalto && !enSuelo){
						dobleSalto = true;
					}
				}
			
			}else{
				corriendo = true;
				refrescarDos.SetActive(false);

				NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeEmpiezaACorrer");
			}
		}
	}
}
