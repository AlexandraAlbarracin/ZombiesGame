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
            //Debug.Log("Hit");
            Barra.transform.position = hit.point;
            //Debug.Log(hit.transform.gameObject.tag.ToString());
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
