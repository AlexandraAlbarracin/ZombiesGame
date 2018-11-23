using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJuego : MonoBehaviour {
    public GameObject CanvasZombie;

    public Image imageUI;
    
    public bool sexo;
    
    public GameObject btnZombie1;
    public GameObject btnZombie2;

    public static int tipo_zombie;
    void Start()
    {
        imageUI = GameObject.Find("Jugador").GetComponent<Image>();
        sexo = ServidorScript.sexo;

        if (sexo == false)
        {
            imageUI.sprite = Resources.Load<Sprite>("Image/hombre");
        }

        if (sexo == true)
        {
            imageUI.sprite = Resources.Load<Sprite>("Image/mujer");
        }
        
        tipo_zombie = 0;
    }

    void Update()
    {
        if (gameObject.tag == "btnZombie1")
        {
            btn_Zombie1();
        }

        if (gameObject.tag == "btnZombie2")
        {
            btn_Zombie2();
        }
    }

    public void btn_Zombie1()
    {
        var m = btnZombie2.GetComponent<Image>();
        m.color = Color.red;
        m = btnZombie1.GetComponent<Image>();
        m.color = Color.green;
        tipo_zombie = 1;
    }

    public void btn_Zombie2()
    {
        var m = btnZombie1.GetComponent<Image>();
        m.color = Color.red;
        m = btnZombie2.GetComponent<Image>();
        m.color = Color.green;
        tipo_zombie = 2;
    }
}
