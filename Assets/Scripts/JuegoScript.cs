using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JuegoScript : MonoBehaviour {
    public Canvas Opciones;

    public GameObject btnCuchillo;
    public GameObject btnPistola;
    public GameObject btnRifle;
    public GameObject btnEscopeta;

    public GameObject btnLlave1;
    public GameObject btnLlave2;
    public GameObject btnLlave3;
    public GameObject btnLlave4;

    public GameObject btnVida1;
    public GameObject btnVida2;
    public GameObject btnVida3;
    public GameObject btnVida4;

    private bool Cuchillo;
    private bool Pistola;
    private bool Rifle;
    private bool Escopeta;

    private bool Llave1;
    private bool Llave2;
    private bool Llave3;
    private bool Llave4;

    private bool Vida1;
    private bool Vida2;
    private bool Vida3;
    private bool Vida4;

    // Use this for initialization
    void Start () {
        Opciones.enabled = false;

        Cuchillo = false;
        Pistola = false;
        Rifle = false;
        Escopeta = false;

        Llave1 = false;
        Llave2 = false;
        Llave3 = false;
        Llave4 = false;

        Vida1 = false;
        Vida2 = false;
        Vida3 = false;
        Vida4 = false;
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void btn_opciones()
    {
        Opciones.enabled = !Opciones.enabled;
    }

    public void btn_Cuchillo()
    {
        if(Cuchillo == false)
        {
            Cuchillo = true;
            var m = btnCuchillo.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Pistola()
    {
        if (Pistola == false)
        {
            Pistola = true;
            var m = btnPistola.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Rifle()
    {
        if (Rifle == false)
        {
            Rifle = true;
            var m = btnRifle.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Escopeta()
    {
        if (Escopeta == false)
        {
            Escopeta = true;
            var m = btnEscopeta.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Llave1()
    {
        if (Llave1 == false)
        {
            Llave1 = true;
            var m = btnLlave1.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Llave2()
    {
        if (Llave2 == false)
        {
            Llave2 = true;
            var m = btnLlave2.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Llave3()
    {
        if (Llave3 == false)
        {
            Llave3 = true;
            var m = btnLlave3.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Llave4()
    {
        if (Llave4 == false)
        {
            Llave4 = true;
            var m = btnLlave4.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Vida1()
    {
        if (Vida1 == false)
        {
            Vida1 = true;
            var m = btnVida1.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Vida2()
    {
        if (Vida2 == false)
        {
            Vida2 = true;
            var m = btnVida2.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Vida3()
    {
        if (Vida3 == false)
        {
            Vida3 = true;
            var m = btnVida3.GetComponent<Image>();
            m.color = Color.green;
        }
    }

    public void btn_Vida4()
    {
        if (Vida4 == false)
        {
            Vida4 = true;
            var m = btnVida4.GetComponent<Image>();
            m.color = Color.green;
        }
    }
}
