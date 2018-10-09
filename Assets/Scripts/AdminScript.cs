using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdminScript : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Opciones;
    public GameObject Instrucciones;
    public GameObject Juego;

    private Animator menuAnim;
    private Animator opcionesAnim;
    private Animator instruccionesAnim;
    private Animator juegoAnim;

    public GameObject btnNuevo;
    public GameObject btnInstruccion;
    public GameObject btnSalir;
    public GameObject btnOpciones;
    public GameObject btnFacil;
    public GameObject btnDificil;
    public GameObject btnHombre;
    public GameObject btnMujer;

    public int btn;
    public bool nivel;
    public bool sexo;

    public LoadingBarScript barscript;

    private void Awake()
    {
        opcionesAnim = Opciones.GetComponent<Animator>();
        menuAnim = Menu.GetComponent<Animator>();
        instruccionesAnim = Instrucciones.GetComponent<Animator>();
        juegoAnim = Juego.GetComponent<Animator>();
    }
    // Use this for initialization
    void Start ()
    {
        btn = -1;
        nivel = false;
        sexo = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(btn.ToString());
        if (btn == 1)
        {
            Debug.Log("Nuevo");
            btn_Nuevo();
            btn = -1;
            barscript.Estado = Estado_Seleccion.NoSeleccionado;
        }
      
        if (btn == 2)
        {
            Debug.Log("Opciones");
            btn_Opciones();
            btn = -1;
            barscript.Estado = Estado_Seleccion.NoSeleccionado;
        }

        if (btn == 3)
        {
            Debug.Log("Instrucciones");
            btn_Instrucciones();
            btn = -1;
            barscript.Estado = Estado_Seleccion.NoSeleccionado;
        }

        if (btn == 4)
        {
            Debug.Log("SaLir");
            btn_Salir();
            btn = -1;
            barscript.Estado = Estado_Seleccion.NoSeleccionado;
        }

        if (btn == 5)
        {
            Debug.Log("Nivel Dificil");
            btn_cambio_dificil();
            btn = -1;
            barscript.Estado = Estado_Seleccion.NoSeleccionado;
        }

        if (btn == 6)
        {
            Debug.Log("Nivel Facil");
            btn_cambio_facil();
            btn = -1;
            barscript.Estado = Estado_Seleccion.NoSeleccionado;
        }
    }

    public void btn_Nuevo()
    {
        Juego.SetActive(true);
        menuAnim.SetBool("Mostrar", false);
        menuAnim.SetBool("Ocultar", true);
        juegoAnim.SetBool("Ocultar", false);
        juegoAnim.SetBool("Mostrar", true);
    }

    public void Jugar()
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
        menuAnim.SetBool("Ocultar", false);
        menuAnim.SetBool("Mostrar", true);
        opcionesAnim.SetBool("Mostrar", false);
        opcionesAnim.SetBool("Ocultar", true);
    }

    public void btn_Instrucciones()
    {
        Instrucciones.SetActive(true);
        menuAnim.SetBool("Mostrar", false);
        menuAnim.SetBool("Ocultar", true);
        instruccionesAnim.SetBool("Ocultar", false);
        instruccionesAnim.SetBool("Mostrar", true);
    }

    public void btn_Retornar1()
    {
        menuAnim.SetBool("Ocultar", false);
        menuAnim.SetBool("Mostrar", true);
        instruccionesAnim.SetBool("Mostrar", false);
        instruccionesAnim.SetBool("Ocultar", true);
    }

    public void btn_cambio_dificil()
    {
        var m = btnFacil.GetComponent<Image>();
        m.color = Color.red;
        m = btnDificil.GetComponent<Image>();
        m.color = Color.green;
        nivel = true;
    }

    public void btn_cambio_facil()
    {
        var m = btnFacil.GetComponent<Image>();
        m.color = Color.green;
        m = btnDificil.GetComponent<Image>();
        m.color = Color.red;
        nivel = false;
    }

    public void btn_Mujer()
    {
        var m = btnMujer.GetComponent<Image>();
        m.color = Color.green;
        m = btnHombre.GetComponent<Image>();
        m.color = Color.red;
        sexo = true;
    }

    public void btn_Hombre()
    {
        var m = btnHombre.GetComponent<Image>();
        m.color = Color.green;
        m = btnMujer.GetComponent<Image>();
        m.color = Color.red;
        sexo = false;
    }
}
