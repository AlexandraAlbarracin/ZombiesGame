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

            if (hit.transform.gameObject.tag == "btnOpciones")
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
            if (hit.transform.gameObject.tag == "btnRetornar")
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
                    tag_actual = "btnOpciones";
                    Debug.Log("Seleccionando Opciones");

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
                    tag_actual = "btnOpciones";
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

            //if (hit.transform.gameObject.tag == "btnInstrucciones")
            //{
            //    Debug.Log("btnInstrucciones");
            //    if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
            //    {
            //        lbScript.time = 0;
            //        lbScript.Estado = Estado_Seleccion.Seleccionando;
            //    }
            //    if (lbScript.Estado == Estado_Seleccion.Seleccionado)
            //    {
            //        Debug.Log("completooooo");
            //        adminScript.btn = 3;
            //        lbScript.Estado = Estado_Seleccion.NoSeleccionado;
            //    }
            //}

            //if (hit.transform.gameObject.tag == "btnSalir")
            //{
            //    Debug.Log("btnSalir");
            //    if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
            //    {
            //        lbScript.time = 0;
            //        lbScript.Estado = Estado_Seleccion.Seleccionando;
            //    }
            //    if (lbScript.Estado == Estado_Seleccion.Seleccionado)
            //    {
            //        Debug.Log("completooooo");
            //        adminScript.btn = 4;
            //        lbScript.Estado = Estado_Seleccion.NoSeleccionado;
            //    }
            //}

            //if (hit.transform.gameObject.tag == "btnDificil")
            //{
            //    Debug.Log("btnDificil");
            //    if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
            //    {
            //        lbScript.time = 0;
            //        lbScript.Estado = Estado_Seleccion.Seleccionando;
            //    }
            //    if (lbScript.Estado == Estado_Seleccion.Seleccionado)
            //    {
            //        Debug.Log("completooooo");
            //        adminScript.btn = 5;
            //        lbScript.Estado = Estado_Seleccion.NoSeleccionado;
            //    }
            //}

            //if (hit.transform.gameObject.tag == "btnFacil")
            //{
            //    Debug.Log("btnFacil");
            //    if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
            //    {
            //        lbScript.time = 0;
            //        lbScript.Estado = Estado_Seleccion.Seleccionando;
            //    }
            //    if (lbScript.Estado == Estado_Seleccion.Seleccionado)
            //    {
            //        Debug.Log("completooooo");
            //        adminScript.btn = 6;
            //        lbScript.Estado = Estado_Seleccion.NoSeleccionado;
            //    }
            //}

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
