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

    // Use this for initialization
    void Start ()
    {
        lbScript = canvas.GetComponent<LoadingBarScript>();
        adminScript = canvas.GetComponent<AdminScript>();
        adminScript.barscript = lbScript;
    }
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(Camara.transform.position, Camara.transform.forward, out hit))
        {
            //Debug.Log("Hit");
            Barra.transform.position = hit.point;
            Debug.Log(hit.transform.gameObject.tag.ToString());

            if (hit.transform.gameObject.tag == "btnNuevo")
            {
                Debug.Log("btnNuevo");
                if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
                {
                    lbScript.time = 0;
                    lbScript.Estado = Estado_Seleccion.Seleccionando;
                }
                if (lbScript.Estado == Estado_Seleccion.Seleccionado)
                {
                    //Debug.Log("completooooo");
                    adminScript.btn = 1;
                    lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                }
            }

            if (hit.transform.gameObject.tag == "btnOpciones")
            {
                Debug.Log("btnOpciones");
                if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
                {
                    lbScript.time = 0;
                    lbScript.Estado = Estado_Seleccion.Seleccionando;
                }
                if (lbScript.Estado == Estado_Seleccion.Seleccionado)
                {
                    //Debug.Log("completooooo");
                    adminScript.btn = 2;
                    lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                }
            }

            if (hit.transform.gameObject.tag == "btnInstrucciones")
            {
                Debug.Log("btnInstrucciones");
                if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
                {
                    lbScript.time = 0;
                    lbScript.Estado = Estado_Seleccion.Seleccionando;
                }
                if (lbScript.Estado == Estado_Seleccion.Seleccionado)
                {
                    //Debug.Log("completooooo");
                    adminScript.btn = 3;
                    lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                }
            }

            if (hit.transform.gameObject.tag == "btnSalir")
            {
                Debug.Log("btnSalir");
                if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
                {
                    lbScript.time = 0;
                    lbScript.Estado = Estado_Seleccion.Seleccionando;
                }
                if (lbScript.Estado == Estado_Seleccion.Seleccionado)
                {
                    //Debug.Log("completooooo");
                    adminScript.btn = 4;
                    lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                }
            }

            if (hit.transform.gameObject.tag == "btnDificil")
            {
                Debug.Log("btnDificil");
                if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
                {
                    lbScript.time = 0;
                    lbScript.Estado = Estado_Seleccion.Seleccionando;
                }
                if (lbScript.Estado == Estado_Seleccion.Seleccionado)
                {
                    //Debug.Log("completooooo");
                    adminScript.btn = 5;
                    lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                }
            }

            if (hit.transform.gameObject.tag == "btnFacil")
            {
                Debug.Log("btnFacil");
                if (lbScript.Estado == Estado_Seleccion.NoSeleccionado)
                {
                    lbScript.time = 0;
                    lbScript.Estado = Estado_Seleccion.Seleccionando;
                }
                if (lbScript.Estado == Estado_Seleccion.Seleccionado)
                {
                    //Debug.Log("completooooo");
                    adminScript.btn = 6;
                    lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                }
            }

            else
            {
                //Debug.Log("No button");
                lbScript.Estado = Estado_Seleccion.NoSeleccionado;
                adminScript.btn = -1;
            }
        }
        else
        {
            //  Debug.Log("No hit");
        }
    }
   
}
