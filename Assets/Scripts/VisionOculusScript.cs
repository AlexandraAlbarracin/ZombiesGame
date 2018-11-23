using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionOculusScript : MonoBehaviour
{
    public Camera Camara;
    public GameObject Barra;
    float tiempo = 0.0f;
    
    public Canvas canvas;
    LoadingBarScript lbScript;
    AdminScript adminScript;
    string tag_actual = "";

    // Use this for initialization
    void Start ()
    {
        lbScript = canvas.GetComponent<LoadingBarScript>();
        adminScript = canvas.GetComponent<AdminScript>();
        adminScript.barscript = lbScript;
        PlayerPrefs.SetString("Estado", "NoSeleccionado");
        PlayerPrefs.SetString("btn", "-1");
    }
	
	// Update is called once per frame
	void Update ()
    {
        string est = PlayerPrefs.GetString("Estado");
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(Camara.transform.position, Camara.transform.forward, out hit))
        {
            Debug.Log("Hit");
            Barra.transform.position = hit.point;
            Debug.Log(hit.transform.gameObject.tag.ToString());
/*Nuevo*/
            if (hit.transform.gameObject.tag == "btnNuevo")
            {
                if(hit.transform.gameObject.tag != tag_actual)
                {
                    //lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
                //Debug.Log("btnNuevo");
                //Debug.Log(Estado_Seleccion.NoSeleccionado.ToString());
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    //lbScript.Estado = Estado_Seleccion.Seleccionando;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnNuevo";
                    //Debug.Log("Seleccionando Nuevo");
                    Debug.Log("################ " + Variables.Estado.ToString());

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    Variables.btn = 1; PlayerPrefs.SetString("btn", "1");
                    //lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
             
            }
/*Opciones*/
            if (hit.transform.gameObject.tag == "btnOpciones")
            {
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
                    
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnOpciones";
                    Debug.Log("Seleccionando Opciones");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "2");
                    Variables.btn = 2;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Instrucciones*/
            if (hit.transform.gameObject.tag == "btnInstrucciones")
            {
                Debug.Log("btnInstrucciones");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnInstrucciones";
                    Debug.Log("Seleccionando Opciones");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "3");
                    Variables.btn = 3;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Salir Juego*/
            if (hit.transform.gameObject.tag == "btnSalir")
            {
                Debug.Log("btnSalir");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnSalir";
                    Debug.Log("Seleccionando Salir");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "4");
                    Variables.btn = 4;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Dificil*/
            if (hit.transform.gameObject.tag == "btnDificil")
            {
                Debug.Log("btnDificil");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnDificil";
                    Debug.Log("Seleccionando Dificil");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "5");
                    Variables.btn = 5;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Facil*/
            if (hit.transform.gameObject.tag == "btnFacil")
            {
                Debug.Log("btnFacil");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnFacil";
                    Debug.Log("Seleccionando Opciones");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "6");
                    Variables.btn = 6;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Retornar Opciones*/
            if (hit.transform.gameObject.tag == "btnRetornar")
            {
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnRetornar";
                    Debug.Log("Seleccionando Retornar");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "7");
                    Variables.btn = 7;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Jugar*/
            if (hit.transform.gameObject.tag == "btnJugar")
            {
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnJugar";
                    Debug.Log("Seleccionando Opciones");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "8");
                    Variables.btn = 8;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Retornar Instrucciones*/
            if (hit.transform.gameObject.tag == "btnRetornar1")
            {
                Debug.Log("btnRetornar1");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnRetornar1";
                    Debug.Log("Seleccionando Retornar1");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "9");
                    Variables.btn = 9;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }

/*Arma1*/
            if (hit.transform.gameObject.tag == "btnArma1")
            {
                Debug.Log("btnArma1");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnArma1";
                    Debug.Log("Seleccionando Arma1");
                    lbScript.sldProgreso.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z);
                    Debug.Log("Posicionando Barra: x"+ hit.transform.position.x + " y: "+ hit.transform.position.y+" z: "+ hit.transform.position.z);
                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                //Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "10");
                    Variables.btn = 10;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
  //                  Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Arma2*/
            if (hit.transform.gameObject.tag == "btnArma2")
            {
                Debug.Log("btnArma2");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnArma2";
                    Debug.Log("Seleccionando Arma2");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "11");
                    Variables.btn = 11;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Arma3*/
            if (hit.transform.gameObject.tag == "btnArma3")
            {
                Debug.Log("btnArma3");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnArma3";
                    Debug.Log("Seleccionando Arma3");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "12");
                    Variables.btn = 12;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Arma4*/
            if (hit.transform.gameObject.tag == "btnArma4")
            {
                Debug.Log("btnArma4");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnArma4";
                    Debug.Log("Seleccionando Arma4");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "13");
                    Variables.btn = 13;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Vida1*/
            if (hit.transform.gameObject.tag == "btnVida1")
            {
                Debug.Log("btnVida1");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnVida1";
                    Debug.Log("Seleccionando Vida1");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "14");
                    Variables.btn = 14;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Vida2*/
            if (hit.transform.gameObject.tag == "btnVida2")
            {
                Debug.Log("btnVida2");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnVida2";
                    Debug.Log("Seleccionando Vida2");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "15");
                    Variables.btn = 15;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Vida3*/
            if (hit.transform.gameObject.tag == "btnVida3")
            {
                Debug.Log("btnVida3");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnVida3";
                    Debug.Log("Seleccionando Vida3");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "16");
                    Variables.btn = 16;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Vida4*/
            if (hit.transform.gameObject.tag == "btnVida4")
            {
                Debug.Log("btnVida4");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnVida4";
                    Debug.Log("Seleccionando Vida4");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "17");
                    Variables.btn = 17;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Mujer*/
            if (hit.transform.gameObject.tag == "btnMujer")
            {
                Debug.Log("btnMujer");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnMujer";
                    Debug.Log("Seleccionando Mujer");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "18");
                    Variables.btn = 18;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Hombre*/
            if (hit.transform.gameObject.tag == "btnHombre")
            {
                Debug.Log("btnHombre");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnHombre";
                    Debug.Log("Seleccionando Hombre");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "19");
                    Variables.btn = 19;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Llave1*/
            if (hit.transform.gameObject.tag == "btnLlave1")
            {
                Debug.Log("btnLlave1");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnLlave1";
                    Debug.Log("Seleccionando Llave1");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "20");
                    Variables.btn = 20;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Llave2*/
            if (hit.transform.gameObject.tag == "btnLlave2")
            {
                Debug.Log("btnLlave2");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnLlave2";
                    Debug.Log("Seleccionando Llave2");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "21");
                    Variables.btn = 21;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Llave3*/
            if (hit.transform.gameObject.tag == "btnLlave3")
            {
                Debug.Log("btnLlave3");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnLlave3";
                    Debug.Log("Seleccionando Llave3");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "22");
                    Variables.btn = 22;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*Llave4*/
            if (hit.transform.gameObject.tag == "btnLlave4")
            {
                Debug.Log("btnLlave4");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnLlave4";
                    Debug.Log("Seleccionando Llave4");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "23");
                    Variables.btn = 23;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarArma1*/
            if (hit.transform.gameObject.tag == "btnUArma1")
            {
                Debug.Log("btnUArma1");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnUArma1";
                    Debug.Log("Seleccionando UArma1");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "24");
                    Variables.btn = 24;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarArma2*/
            if (hit.transform.gameObject.tag == "btnUArma2")
            {
                Debug.Log("btnUArma2");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnUArma2";
                    Debug.Log("Seleccionando UArma2");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "25");
                    Variables.btn = 25;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarArma3*/
            if (hit.transform.gameObject.tag == "btnUArma3")
            {
                Debug.Log("btnUArma3");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnUArma3";
                    Debug.Log("Seleccionando UArma3");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "26");
                    Variables.btn = 26;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarArma4*/
            if (hit.transform.gameObject.tag == "btnUArma4")
            {
                Debug.Log("btnUArma4");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnUArma4";
                    Debug.Log("Seleccionando UArma4");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "27");
                    Variables.btn = 27;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarLlave1*/
            if (hit.transform.gameObject.tag == "btnULlave1")
            {
                Debug.Log("btnULlave1");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnULlave1";
                    Debug.Log("Seleccionando ULlave1");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "28");
                    Variables.btn = 28;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarLlave2*/
            if (hit.transform.gameObject.tag == "btnULlave2")
            {
                Debug.Log("btnULlave2");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnULlave2";
                    Debug.Log("Seleccionando ULlave2");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "29");
                    Variables.btn = 29;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarLlave3*/
            if (hit.transform.gameObject.tag == "btnULlave3")
            {
                Debug.Log("btnULlave3");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnULlave3";
                    Debug.Log("Seleccionando ULlave3");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "30");
                    Variables.btn = 30;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarLlave4*/
            if (hit.transform.gameObject.tag == "btnULlave4")
            {
                Debug.Log("btnULlave4");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnULlave4";
                    Debug.Log("Seleccionando ULlave4");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "31");
                    Variables.btn = 31;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarVida1*/
            if (hit.transform.gameObject.tag == "btnUVida1")
            {
                Debug.Log("btnUVida1");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnUVida1";
                    Debug.Log("Seleccionando UVida1");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "32");
                    Variables.btn = 32;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarVida2*/
            if (hit.transform.gameObject.tag == "btnUVida2")
            {
                Debug.Log("btnUVida2");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnUVida2";
                    Debug.Log("Seleccionando UVida2");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "33");
                    Variables.btn = 33;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarVida3*/
            if (hit.transform.gameObject.tag == "btnUVida3")
            {
                Debug.Log("btnUVida3");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnUVida3";
                    Debug.Log("Seleccionando UVida3");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "34");
                    Variables.btn = 34;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
/*UsarVida4*/
            if (hit.transform.gameObject.tag == "btnUVida4")
            {
                Debug.Log("btnUVida4");
                if (hit.transform.gameObject.tag != tag_actual)
                {
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }

                // Debug.Log("btnOpciones");
                if (est == Estado_Seleccion.NoSeleccionado.ToString())
                {
                    lbScript.time = 0;
                    Variables.Estado = Estado_Seleccion.Seleccionando.ToString(); PlayerPrefs.SetString("Estado", "Seleccionando");
                    tag_actual = "btnUVida4";
                    Debug.Log("Seleccionando UVida4");

                    PlayerPrefs.SetString("Estado", "Seleccionando");
                }

                Debug.Log(Variables.btn.ToString());

                if (est == Estado_Seleccion.Seleccionado.ToString())
                {
                    PlayerPrefs.SetString("btn", "35");
                    Variables.btn = 35;
                    Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
                    Debug.Log(Variables.btn.ToString());

                    PlayerPrefs.SetString("Estado", "NoSeleccionado");
                }
            }
            else
            {
                //Debug.Log("No button");
                Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString();
                Variables.btn = -1;
            }
        }
        else
        {
            //  Debug.Log("No hit");
        }
    }
   
}
