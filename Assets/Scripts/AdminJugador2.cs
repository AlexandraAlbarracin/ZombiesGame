using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdminJugador2 : MonoBehaviour {
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
    public GameObject btnJugar;
    public GameObject btnAldea;
    public GameObject btnAlmacen;
    public GameObject btnCasaAldea;
    public GameObject btnCasaLago;
    public GameObject btnCementerio;
    public GameObject btnEstablo;
    public GameObject btnLago;
    public GameObject btnMansion;

    public bool nivel;
    public static string elegido;

    private void Start()
    {
        opcionesAnim = Opciones.GetComponent<Animator>();
        menuAnim = Menu.GetComponent<Animator>();
        instruccionesAnim = Instrucciones.GetComponent<Animator>();
        juegoAnim = Juego.GetComponent<Animator>();
        nivel = false;
        elegido = "btnAldea";
    }

    void Update()
    {
        if (gameObject.tag == "btnNuevo")
        {
            Debug.Log("Nuevo");
            btn_Nuevo();
        }

        if (gameObject.tag == "btnOpciones")
        {
            Debug.Log("Opciones");
            btn_Opciones();
        }

        if (gameObject.tag == "btnInstrucciones")
        {
            Debug.Log("Instrucciones");
            btn_Instrucciones();
        }

        if (gameObject.tag == "btnSalir")
        {
            Debug.Log("Salir");
            btn_Salir();
        }

        if (gameObject.tag == "btnDificil")
        {
            Debug.Log("Nivel Dificil");
            btn_cambio_dificil();
        }

        if (gameObject.tag == "btnFacil")
        {
            Debug.Log("Nivel Facil");
            btn_cambio_facil();
        }
        if (gameObject.tag == "btnRetornar")
        {
            Debug.Log("Retornar");
            btn_Retornar();
        }
        if (gameObject.tag == "btnJugar")
        {
            Debug.Log("Juego");
            btn_Juego();
        }
        if (gameObject.tag == "btnRetornar1")
        {
            Debug.Log("Retornar Opciones");
            btn_Retornar1();           
        }
        
        if (gameObject.tag == "btnAldea")
        {
            Debug.Log("Aldea");
            btn_Aldea();
        }
        if (gameObject.tag == "btnAlmacen")
        {
            Debug.Log("Almacen");
            btn_Almacen();
        }
        if (gameObject.tag == "btnCasaAldea")
        {
            Debug.Log("Cada de la Aldea");
            btn_CasaAldea();
        }
        if (gameObject.tag == "btnCasaLago")
        {
            Debug.Log("Casa del Lago");
            btn_CasaLago();
        }
        if (gameObject.tag == "btnCementerio")
        {
            Debug.Log("Cementerio");
            btn_Cementerio();
        }
        if (gameObject.tag == "btnEstablo")
        {
            Debug.Log("Establo");
            btn_Establo();
        }
        if (gameObject.tag == "btnLago")
        {
            Debug.Log("Lago");
            btn_Lago();
        }
        if (gameObject.tag == "btnMansion")
        {
            Debug.Log("Mansion");
            btn_Mansion();
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

        SceneManager.LoadScene(2);
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
        Debug.Log("entreeee");
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

   

    public void cambiar_color()
    {
        if (elegido == "btnAldea")
        {
            var m = btnAldea.GetComponent<Image>();
            m.color = Color.red;
        }

        if (elegido == "btnAlmacen")
        {
            var m = btnAlmacen.GetComponent<Image>();
            m.color = Color.red;
        }

        if (elegido == "btnCasaAldea")
        {
            var m = btnCasaAldea.GetComponent<Image>();
            m.color = Color.red;
        }

        if (elegido == "btnCasaLago")
        {
            var m = btnCasaLago.GetComponent<Image>();
            m.color = Color.red;
        }

        if (elegido == "btnCementerio")
        {
            var m = btnCementerio.GetComponent<Image>();
            m.color = Color.red;
        }

        if (elegido == "btnEstablo")
        {
            var m = btnEstablo.GetComponent<Image>();
            m.color = Color.red;
        }

        if (elegido == "btnLago")
        {
            var m = btnLago.GetComponent<Image>();
            m.color = Color.red;
        }

        if (elegido == "btnMansion")
        {
            var m = btnMansion.GetComponent<Image>();
            m.color = Color.red;
        }
    }

    public void btn_Aldea()
    {
        var m = btnAldea.GetComponent<Image>();
        m.color = Color.green;
        cambiar_color();
        elegido = "btnAldea";
    }

    public void btn_Almacen()
    {
        var m = btnAlmacen.GetComponent<Image>();
        m.color = Color.green;
        cambiar_color();
        elegido = "btnAlmacen";
    }

    public void btn_CasaAldea()
    {
        var m = btnCasaAldea.GetComponent<Image>();
        m.color = Color.green;
        cambiar_color();
        elegido = "btnCasaAldea";
    }

    public void btn_CasaLago()
    {
        var m = btnCasaLago.GetComponent<Image>();
        m.color = Color.green;
        cambiar_color();
        elegido = "btnCasaLago";
    }

    public void btn_Cementerio()
    {
        var m = btnCementerio.GetComponent<Image>();
        m.color = Color.green;
        cambiar_color();
        elegido = "btnCementerio";
    }

    public void btn_Establo()
    {
        var m = btnEstablo.GetComponent<Image>();
        m.color = Color.green;
        cambiar_color();
        elegido = "btnEstablo";
    }

    public void btn_Lago()
    {
        var m = btnLago.GetComponent<Image>();
        m.color = Color.green;
        cambiar_color();
        elegido = "btnLago";
    }

    public void btn_Mansion()
    {
        var m = btnMansion.GetComponent<Image>();
        m.color = Color.green;
        cambiar_color();
        elegido = "btnMansion";
    }

}
