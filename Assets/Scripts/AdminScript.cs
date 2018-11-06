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
    public GameObject btnJugar;

    //public int btn;
    public bool nivel;
    public static bool sexo;
    public static bool Arma1;
    public static bool Arma2;
    public static bool Arma3;
    public static bool Arma4;
    public static int Vida1;
    public static int Vida2;
    public static int Vida3;
    public static int Vida4;


    public LoadingBarScript barscript;
    public HealthBar healthBar;

    private void Start()
    {
        PlayerPrefs.SetString("Estado", "NoSeleccionado");
        opcionesAnim = Opciones.GetComponent<Animator>();
        menuAnim = Menu.GetComponent<Animator>();
        instruccionesAnim = Instrucciones.GetComponent<Animator>();
        juegoAnim = Juego.GetComponent<Animator>();
        //btn = -1;
        nivel = false;
        sexo = false;
        Arma1 = false;
        Arma2 = false;
        Arma3 = false;
        Arma4 = false;
        Vida1 = 0;
        Vida2 = 0;
        Vida3 = 0;
        Vida4 = 0;
    }

    void Update ()
    {
        string btn = PlayerPrefs.GetString("btn");
        Debug.Log("btnnnnnnnnnnnnnnnn" + btn);
        if (btn == "1")
        {
            Debug.Log("Nuevo");
            btn_Nuevo();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString();
            PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
      
        if (btn == "2")
        {
            Debug.Log("Opciones");
            btn_Opciones();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }

        if (btn == "3")
        {
            Debug.Log("Instrucciones");
            btn_Instrucciones();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }

        if (btn == "4")
        {
            Debug.Log("Salir");
            btn_Salir();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }

        if (btn == "5")
        {
            Debug.Log("Nivel Dificil");
            btn_cambio_dificil();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }

        if (btn == "6")
        {
            Debug.Log("Nivel Facil");
            btn_cambio_facil();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "7")
        {
            Debug.Log("Retornar");
            btn_Retornar();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "8")
        {
            Debug.Log("Juego");
            btn_Juego();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "9")
        {
            Debug.Log("Retornar");
            btn_Retornar1();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "10")
        {
            Debug.Log("Arma1");
            btn_Arma1();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
    }

    public void btn_Nuevo()
    {
        Debug.Log("Nuevo");
        Juego.SetActive(true);
        menuAnim.SetBool("Mostrar", false);
        menuAnim.SetBool("Ocultar", true);
        juegoAnim.SetBool("Ocultar", false);
        juegoAnim.SetBool("Mostrar", true);
    }

    public void btn_Juego()
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
        //Application.Quit();
        Debug.Log("Salir");
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

    public void btn_Arma1()
    {
        Arma1 = true;
    }

    public void btn_Arma2()
    {
        Arma2 = true;
    }

    public void btn_Arma3()
    {
        Arma3 = true;
    }

    public void btn_Arma4()
    {
        Arma4 = true;

    }

    public void btn_Vida1()
    {
        Vida1 += Vida1;
        //healthBar.AddHealth(5);
    }

    public void btn_Vida2()
    {
        Vida2 += Vida2;
       // healthBar.AddHealth(10);
    }

    public void btn_Vida3()
    {
        Vida3 += Vida3;
      //  healthBar.AddHealth(15);
    }

    public void btn_Vida4()
    {
        Vida4 += Vida4;
       // healthBar.AddHealth(20
          //  );
    }
}
