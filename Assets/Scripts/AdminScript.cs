using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
    public static bool Vida1;
    public static bool Vida2;
    public static bool Vida3;
    public static bool Vida4;
    public static bool Llave1;
    public static bool Llave2;
    public static bool Llave3;
    public static bool Llave4;
    public static int cVida1;
    public static int cVida2;
    public static int cVida3;
    public static int cVida4;

    public Image ArmaAldea;
    public Image ArmaAlmacen;
    public Image ArmaEstablo;
    public Image ArmaMansion;
    public Image LlaveAldea;
    public Image LlaveAlmacen;
    public Image LlaveEstablo;
    public Image LlaveMansion;
    public Image VidaAldea;
    public Image VidaAlmacen;
    public Image VidaEstablo;
    public Image VidaMansion;
    public Image ArmaAldeaM;
    public Image ArmaAlmacenM;
    public Image ArmaEstabloM;
    public Image ArmaMansionM;

    public LoadingBarScript barscript;
    public HealthBar healthBar;

    public string activa;

    //GraphicRaycaster m_Raycaster;
    //PointerEventData m_PointerEventData;
    //EventSystem m_EventSystem;

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
        Vida1 = false;
        Vida2 = false;
        Vida3 = false;
        Vida4 = false;
        Llave1 = false;
        Llave2 = false;
        Llave3 = false;
        Llave4 = false;
        cVida1 = 0;
        cVida2 = 0;
        cVida3 = 0;
        cVida4 = 0;
        activa = "";
        //m_Raycaster = GetComponent<GraphicRaycaster>();
        //m_EventSystem = GetComponent<EventSystem>();
    }

    void Update()
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
            Debug.Log("Retornar Opciones");
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
        if (btn == "11")
        {
            Debug.Log("Arma2");
            btn_Arma2();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "12")
        {
            Debug.Log("Arma3");
            btn_Arma3();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "13")
        {
            Debug.Log("Arma4");
            btn_Arma4();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "14")
        {
            Debug.Log("Vida1");
            btn_Vida1();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "15")
        {
            Debug.Log("Vida2");
            btn_Vida2();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "16")
        {
            Debug.Log("Vida3");
            btn_Vida3();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "17")
        {
            Debug.Log("Vida4");
            btn_Vida4();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "18")
        {
            Debug.Log("Mujer");
            btn_Mujer();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "19")
        {
            Debug.Log("Hombre");
            btn_Hombre();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "20")
        {
            Debug.Log("Llave1");
            btn_Llave1();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "21")
        {
            Debug.Log("Llave2");
            btn_Llave2();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "22")
        {
            Debug.Log("Llave3");
            btn_Llave3();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "23")
        {
            Debug.Log("Llave4");
            btn_Llave4();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "24")
        {
            Debug.Log("uArma1");
            btn_uArma1();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "25")
        {
            Debug.Log("uArma2");
            btn_uArma2();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "26")
        {
            Debug.Log("uArma3");
            btn_uArma4();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "27")
        {
            Debug.Log("uArma4");
            btn_uArma4();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "28")
        {
            Debug.Log("uLlave1");
            btn_uLlave1();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "29")
        {
            Debug.Log("uLlave2");
            btn_uLlave2();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "30")
        {
            Debug.Log("uLlave3");
            btn_uLlave3();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "31")
        {
            Debug.Log("uLlave4");
            btn_uLlave4();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "32")
        {
            Debug.Log("uVida1");
            btn_uVida1();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "33")
        {
            Debug.Log("uVida2");
            btn_uVida2();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "34")
        {
            Debug.Log("uVida3");
            btn_uVida3();
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
            Variables.Estado = Estado_Seleccion.NoSeleccionado.ToString(); PlayerPrefs.SetString("Estado", "NoSeleccionado");
        }
        if (btn == "35")
        {
            Debug.Log("uVida4");
            btn_uVida4();
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
        if (Arma1 == false)
        {
            Arma1 = true;
            ArmaAldea.enabled = true;
        }
        
        Debug.Log("Arma1");
    }

    public void btn_Arma2()
    {
        if (Arma2 == false)
        {
            Arma2 = true;
            ArmaAlmacen.enabled = true;

        }
        Debug.Log("Arma2");
    }

    public void btn_Arma3()
    {
        if (Arma3 == false)
        {
            Arma3 = true;
            ArmaEstablo.enabled = true;
        }
        Debug.Log("Arma3");
    }

    public void btn_Arma4()
    {
        if (Arma4 == false)
        {
            Arma4 = true;
            ArmaMansion.enabled = true;
        }
        Debug.Log("Arma4");

    }

    public void btn_Vida1()
    {
        if (Vida1 == false)
        {
            Vida1 = true;
            VidaAldea.enabled = true;
        }
        cVida1 += 1;
        Debug.Log("Vida1");
        //healthBar.AddHealth(5);
    }

    public void btn_Vida2()
    {
        if (Vida2 == false)
        {
            Vida2 = true;
            VidaAlmacen.enabled = true;
        }
        cVida2 += 1;
        Debug.Log("Vida2");
        //healthBar.AddHealth(5);
    }

    public void btn_Vida3()
    {
        if (Vida3 == false)
        {
            Vida3 = true;
            VidaEstablo.enabled = true;
        }
        cVida3 += 1;
        Debug.Log("Vida3");
        //
    }

    public void btn_Vida4()
    {
        if (Vida4 == false)
        {
            Vida4 = true;
            VidaMansion.enabled = true;
        }
        cVida4 += 1;
        Debug.Log("Vida4");
        //healthBar.AddHealth(5);
    }

    public void btn_Llave1()
    {
        if (Llave1 == false)
        {
            Llave1 = true;
            LlaveAlmacen.enabled = true;
        }
        Debug.Log("Llave1");
    }

    public void btn_Llave2()
    {
        if (Llave2 == false)
        {
            Llave2 = true;
            LlaveAldea.enabled = true;
        }
        Debug.Log("Llave2");
    }

    public void btn_Llave3()
    {
        if (Llave3 == false)
        {
            Llave3 = true;
            LlaveEstablo.enabled = true;
        }
        Debug.Log("Llave3");
    }

    public void btn_Llave4()
    {
        if (Llave4 == false)
        {
            Llave4 = true;
            LlaveMansion.enabled = true;
        }
        Debug.Log("Llave4");
    }

    public void cambiar_arma()
    {
        if(activa == "ArmaAldea")
        {
            ArmaAldeaM.enabled = false;
        }

        if(activa == "ArmaAlmacen")
        {
            ArmaAlmacenM.enabled = false;
        }

        if(activa == "ArmaEstablo")
        {
            ArmaEstabloM.enabled = false;
        }

        if(activa == "ArmaMansion")
        {
            ArmaMansionM.enabled = false;
        }
    }

    public void btn_uArma1()
    {
        cambiar_arma();
        ArmaAldeaM.enabled = true;
        activa = "ArmaAldea";
        Debug.Log("uArma1");
    }

    public void btn_uArma2()
    {
        cambiar_arma();
        ArmaAlmacenM.enabled = true;
        activa = "ArmaAlmacen";
        Debug.Log("uArma2");
    }

    public void btn_uArma3()
    {
        cambiar_arma();
        ArmaEstabloM.enabled = true;
        activa = "ArmaEstablo";
        Debug.Log("uArma3");
    }

    public void btn_uArma4()
    {
        cambiar_arma();
        ArmaMansionM.enabled = true;
        activa = "ArmaMansion";
        Debug.Log("uArma4");
    }

    public void btn_uLlave1()
    {
        //Cambiar arma
        Debug.Log("uLlave1");
    }

    public void btn_uLlave2()
    {
        //Cambiar arma
        Debug.Log("uLlave2");
    }

    public void btn_uLlave3()
    {
        //Cambiar arma
        Debug.Log("uLlave3");
    }

    public void btn_uLlave4()
    {
        //Cambiar arma
        Debug.Log("uLlave4");
    }

    public void btn_uVida1()
    {
        cVida1 -= 1;
        healthBar.AddHealth(5);
        if (cVida1 < 1)
        {
            VidaAldea.enabled = false;
            cVida1 = 0;
        }
        Debug.Log("uVida1");
    }

    public void btn_uVida2()
    {
        cVida2 -= 1;
        healthBar.AddHealth(10);
        if (cVida2 < 1)
        {
            VidaAlmacen.enabled = false;
            cVida2 = 0;
        }
        Debug.Log("uVida2");
    }

    public void btn_uVida3()
    {
        cVida3 -= 1;
        healthBar.AddHealth(15);
        if (cVida3 < 1)
        {
            VidaEstablo.enabled = false;
            cVida3 = 0;
        }
        Debug.Log("uVida3");
    }

    public void btn_uVida4()
    {
        cVida4 -= 1;
        healthBar.AddHealth(20);
        if (cVida4 < 1)
        {
            VidaMansion.enabled = false;
            cVida4 = 0;
        }
        Debug.Log("uVida1");
    }
}
