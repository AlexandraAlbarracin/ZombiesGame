using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdminScript : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Opciones;
    private Animator menuAnim;
    private Animator opcionesAnim;
    private Animator terrenoAnim;

    public GameObject btnNuevo;
    public GameObject btnCargar;
    public GameObject btnSalir;
    public GameObject btnOpciones;
    public int btn;

    public GameObject cnvTerrain;

    private void Awake()
    {
        opcionesAnim = Opciones.GetComponent<Animator>();
        menuAnim = Menu.GetComponent<Animator>();
        terrenoAnim = cnvTerrain.GetComponent<Animator>();
    }
    // Use this for initialization
    void Start ()
    {
        btn = -1;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(btn.ToString());
        if (btn == 1)
        {
            Debug.Log("Nuevo");
            btn_Nuevo();
        }

        if (btn == 2)
        {
            Debug.Log("opciones");
            btn_Opciones();
            btn = -1;
        }

        if (btn == 3)
        {
            Debug.Log("Instrucciones");
            btn_Salir();
        }

        if (btn == 4)
        {
            Debug.Log("SaLir");
            btn_Salir();
        }
    }

    public void btn_Nuevo()
    {
        SceneManager.LoadScene(1);
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
        Application.Quit();
    }
    public void btn_Retornar()
    {
        //Opciones.SetActive(false);
        menuAnim.SetBool("Ocultar", false);
        menuAnim.SetBool("Mostrar", true);
        opcionesAnim.SetBool("Mostrar", false);
        opcionesAnim.SetBool("Ocultar", true);
    }

    public void btn_Instrucciones()
    {
        Opciones.SetActive(true);
        menuAnim.SetBool("Mostrar", false);
        menuAnim.SetBool("Ocultar", true);
        opcionesAnim.SetBool("Ocultar", false);
        opcionesAnim.SetBool("Mostrar", true);
    }
}
