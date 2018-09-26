using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminScript : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Opciones;
    private Animator menuAnim;
    private Animator opcionesAnim;

    public GameObject btnNuevo;
    public GameObject btnCargar;
    public GameObject btnSalir;
    public GameObject btnOpciones;
    public int btn;
   
    private void Awake()
    {
        opcionesAnim = Opciones.GetComponent<Animator>();
        menuAnim = Menu.GetComponent<Animator>();
       
    }
    // Use this for initialization
    void Start ()
    {
        btn = -1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (btn == 3)
        {
            Debug.Log("completo000000000");
            btn_Opciones();
            btn = -1;
        }
	}
    public void btn_Opciones()
    {
        Opciones.SetActive(true);
        menuAnim.SetBool("Mostrar", false);
        menuAnim.SetBool("Ocultar", true);
        opcionesAnim.SetBool("Ocultar", false);
        opcionesAnim.SetBool("Mostrar", true);
    }
    public void btn_Salir()
    {

    }
    public void btn_Retornar()
    {
        //Opciones.SetActive(false);
        menuAnim.SetBool("Ocultar", false);
        menuAnim.SetBool("Mostrar", true);
        opcionesAnim.SetBool("Mostrar", false);
        opcionesAnim.SetBool("Ocultar", true);
    }
}
