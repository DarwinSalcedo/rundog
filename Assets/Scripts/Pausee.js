#pragma strict


var muestra : boolean;

function Update () {
    if (Input.GetKeyDown (KeyCode.P)) {
         Time.timeScale = 1.0-Time.timeScale;
         Time.fixedDeltaTime = 0.02 * Time.timeScale;
         muestra=!muestra;
    }
  
}

function OnGUI(){
 if(muestra){
     GUI.Label(Rect(230,130,400,400), "jaja"); // muestra textura
     GUI.Label(Rect(100, 100, 50, 30), "Pausa"); // muestra texto
    }
}