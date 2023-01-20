using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

	 public Transform inicioVista,finVista;
    public bool encontrado;
    //public bool izquierda;
    public GameObject exclamacion;
 
    // Use this for initialization
    void Start () {
       // InvokeRepeating ("Vigilar", 0f, Random.Range(2f,6f));
    }
 
    // Update is called once per frame
    void Update () {
        Raycasting ();
        Comportamiento ();
    }
 
    private void Comportamiento(){
        if (encontrado) {
			NotificationCenter.DefaultCenter().PostNotification(this, "correr");
        }
    }
 
    void Raycasting(){
       // Debug.DrawLine (inicioVista.position, finVista.position, Color.red);
        encontrado = Physics2D.Linecast (inicioVista.position, finVista.position,9<< LayerMask.NameToLayer("Jugador"));
 	
    }
 
}
