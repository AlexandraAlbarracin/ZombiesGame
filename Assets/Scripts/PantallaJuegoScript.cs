using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantallaJuegoScript : MonoBehaviour {

    public GameObject imgArma;
    public Sprite spriteCuchillo;
    public Sprite spritePistola;
    public Sprite spriteRifle;
    public Sprite spriteEscopeta;
    public GameObject canvassubmenu;
    public AdminScript adminScript;

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

    public GameObject btnArmaAldea;
    public GameObject btnArmaAlmacen;
    public GameObject btnArmaEstablo;
    public GameObject btnArmaMansion;
    public GameObject btnLlaveAldea;
    public GameObject btnLlaveAlmacen;
    public GameObject btnLlaveEstablo;
    public GameObject btnLlaveMansion;
    public GameObject btnVidaAldea;
    public GameObject btnVidaAlmacen;
    public GameObject btnVidaEstablo;
    public GameObject btnVidaMansion;


    public HealthBar healthBar;

    public string actual;
    // Use this for initialization
    void Start ()
    {
        canvassubmenu.SetActive(false);
        //ActualizarArma(4);
        ArmaAldea.enabled = false;
        ArmaAlmacen.enabled = false;
        ArmaEstablo.enabled = false;
        ArmaMansion.enabled = false;
        LlaveAldea.enabled = false;
        LlaveAlmacen.enabled = false;
        LlaveEstablo.enabled = false;
        LlaveMansion.enabled = false;
        VidaAldea.enabled = false;
        VidaAlmacen.enabled = false;
        VidaEstablo.enabled = false;
        VidaMansion.enabled = false;
        actual = "ArmaMansion";
        var m = btnArmaMansion.GetComponent<Image>();
        m.color = Color.yellow;
    }
    public bool submenu;
	// Update is called once per frame
	void Update ()
    {
        //"joystick 1 button 0" cuadrado
        //"joystick 1 button 1" x
        //"joystick 1 button 2" circulo
        //"joystick 1 button 3" triangulo

        if (Input.GetKeyDown("joystick 1 button 1"))
        //if(Input.GetKeyDown("p"))
        {
            submenu = !submenu;
            canvassubmenu.SetActive(submenu);
            cambiar_inicio();
            var n = btnArmaMansion.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaMansion";
            //Debug.Log("boton x");
        }

        if (Input.GetKeyDown("r"))
        {
            
            cambio_boton("r");
        }

        if (Input.GetKeyDown("o"))
        {
            cambio_boton("o");
        }

        if (Input.GetKeyDown("l"))
        {
            cambio_boton("l");
        }

        if (Input.GetKeyDown("u"))
        {
            cambio_boton("u");
        }
        if (Input.GetKeyDown("joystick 1 button 3")) 
        //if (Input.GetKeyDown("k"))
        {
            seleccionar_boton();
        }

    }
    public void ActualizarArma(int n)
    {
        Image img = imgArma.GetComponent<Image>();
        if (n == 1)
            img.sprite = spriteCuchillo;
        if (n == 2)
            img.sprite = spritePistola;
        if (n == 3)
            img.sprite = spriteRifle;
        if (n == 4)
            img.sprite = spriteEscopeta;
        img.enabled = true;
    }
    public void btn_Cuchillo()
    {
        ActualizarArma(1);
    }
    public void btn_Pistola()
    {
        ActualizarArma(2);
        Debug.Log("click pistola");
    }
    public void btn_Rifle()
    {
        ActualizarArma(3);
    }
    public void btn_Escopeta()
    {
        ActualizarArma(4);
    }

    public void movimiento_ArmaMansion(string m)
    {
        if(m == "r")
        {
            var n = btnArmaMansion.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveMansion.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveMansion";
        }

        if (m == "o")
        {
            var n = btnArmaMansion.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaEstablo";
        }
    }

    public void movimiento_ArmaEstablo(string m)
    {
        if(m == "r")
        {
            var n = btnArmaEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveEstablo";
        }

        if(m == "o")
        {
            var n = btnArmaEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaAlmacen";
        }

        if(m == "u")
        {
            var n = btnArmaEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaMansion.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaMansion";
        }
    }

    public void movimiento_ArmaAlmacen(string m)
    {
        if(m == "r")
        {
            var n = btnArmaAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveAlmacen";
        }

        if(m == "o")
        {
            var n = btnArmaAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaAldea.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaAldea";
        }

        if(m == "u")
        {
            var n = btnArmaAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaEstablo";
        }
    }

    public void movimiento_ArmaAldea(string m)
    {
        if(m == "r")
        {
            var n = btnArmaAldea.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveAldea.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveAldea";
        }

        if(m == "u")
        {
            var n = btnArmaAldea.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaAlmacen";
        }
    }

    public void movimiento_LlaveMansion(string m)
    {
        if(m == "r")
        {
            var n = btnLlaveMansion.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaMansion.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaMansion";
        }

        if(m == "o")
        {
            var n = btnLlaveMansion.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaEstablo";
        }

        if(m == "l")
        {
            var n = btnLlaveMansion.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaMansion.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaMansion";
        }
    }

    public void movimiento_LlaveEstablo(string m)
    {
        if(m == "r")
        {
            var n = btnLlaveEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaEstablo";
        }

        if(m == "o")
        {
            var n = btnLlaveEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaAlmacen";
        }

        if(m == "u")
        {
            var n = btnLlaveEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveMansion.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveMansion";
        }

        if(m == "l")
        {
            var n = btnLlaveEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaEstablo";
        }
    }

    public void movimiento_LlaveAlmacen(string m)
    {
        if(m == "r")
        {
            var n = btnLlaveAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaAlmacen";
        }

        if(m == "o")
        {
            var n = btnLlaveAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveAldea.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveAldea";
        }
        
        if(m == "u")
        {
            var n = btnLlaveAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveEstablo";
        }

        if(m == "l")
        {
            var n = btnLlaveAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaAlmacen";
        }
    }

    public void movimiento_LlaveAldea(string m)
    {
        if(m == "r")
        {
            var n = btnLlaveAldea.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaAldea.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaAldea";
        }

        if (m == "u")
        {
            var n = btnLlaveAldea.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaAlmacen";
        }

        if (m == "l")
        {
            var n = btnLlaveAldea.GetComponent<Image>();
            n.color = Color.gray;
            n = btnArmaAldea.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "ArmaAldea";
        }
    }

    public void movimiento_VidaMansion(string m)
    {
        if (m == "l")
        {
            var n = btnVidaMansion.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveMansion.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveMansion";
        }

        if (m == "o")
        {
            var n = btnVidaMansion.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaEstablo";
        }
    }

    public void movimiento_VidaEstablo(string m)
    {
        if(m == "l")
        {
            var n = btnVidaEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveEstablo";
        }

        if (m == "o")
        {
            var n = btnVidaEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaAlmacen";
        }

        if (m == "u")
        {
            var n = btnVidaEstablo.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaMansion.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaMansion";
        }
    }

    public void movimiento_VidaAlmacen(string m)
    {
        if (m == "l")
        {
            var n = btnVidaAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveAlmacen";
        }

        if (m == "o")
        {
            var n = btnVidaAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaAldea.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaAldea";
        }

        if (m == "u")
        {
            var n = btnVidaAlmacen.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaEstablo";
        }
    }

    public void movimiento_VidaAldea(string m)
    {
        if (m == "l")
        {
            var n = btnVidaAldea.GetComponent<Image>();
            n.color = Color.gray;
            n = btnLlaveAldea.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "LlaveAldea";
        }

        if (m == "u")
        {
            var n = btnVidaAldea.GetComponent<Image>();
            n.color = Color.gray;
            n = btnVidaAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            actual = "VidaAlmacen";
        }
    }

    public void cambio_boton(string t)
    {
        if(actual == "ArmaMansion")
        {
            movimiento_ArmaMansion(t);
            return;

        }

        if (actual == "ArmaEstablo")
        {
            movimiento_ArmaEstablo(t);
            return;
        }

        if (actual == "ArmaAlmacen")
        {
            movimiento_ArmaAlmacen(t);
            return;
        }

        if (actual == "ArmaAldea")
        {
            movimiento_ArmaAldea(t);
            return;
        }

        if (actual == "LlaveMansion")
        {
            movimiento_LlaveMansion(t);
            return;
        }

        if (actual == "LlaveEstablo")
        {
            movimiento_LlaveEstablo(t);
            return;
        }

        if (actual == "LlaveAlmacen")
        {
            movimiento_LlaveAlmacen(t);
            return;
        }

        if (actual == "LlaveAldea")
        {
            movimiento_LlaveAldea(t);
            return;
        }

        if (actual == "VidaMansion")
        {
            movimiento_VidaMansion(t);
            return;
        }

        if (actual == "VidaEstablo")
        {
            movimiento_VidaEstablo(t);
            return;
        }

        if (actual == "VidaAlmacen")
        {
            movimiento_VidaAlmacen(t);
            return;
        }

        if (actual == "VidaAldea")
        {
            movimiento_VidaAldea(t);
            return;
        }
    }

    public void cambiar_inicio()
    {
        if(actual == "ArmaEstablo")
        {
            var n = btnArmaEstablo.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "ArmaAlmacen")
        {
            var n = btnArmaAlmacen.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "ArmaAldea")
        {
            var n = btnArmaAldea.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "LlaveEstablo")
        {
            var n = btnLlaveEstablo.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "LlaveMansion")
        {
            var n = btnLlaveMansion.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "LlaveAlmacen")
        {
            var n = btnLlaveAlmacen.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "LlaveAldea")
        {
            var n = btnLlaveAldea.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "VidaEstablo")
        {
            var n = btnVidaEstablo.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "VidaMansion")
        {
            var n = btnVidaMansion.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "VidaAldea")
        {
            var n = btnVidaAldea.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "VidaAlmacen")
        {
            var n = btnVidaAlmacen.GetComponent<Image>();
            n.color = Color.gray;
        }

        if (actual == "LlaveEstablo")
        {
            var n = btnArmaEstablo.GetComponent<Image>();
            n.color = Color.gray;
        }
    }

    public void seleccionar_boton()
    {
        if (actual == "ArmaEstablo")
        {
            if (ArmaEstablo.enabled == true)
            {
                
            }
            return;
        }

        if (actual == "ArmaMansion")
        {
            if (ArmaMansion.enabled == true)
            {
                
            }
            return;
        }

        if (actual == "ArmaAlmacen")
        {
            if (ArmaAlmacen.enabled == true)
            {
                
            }
            return;
        }

        if (actual == "ArmaAldea")
        {
            if (ArmaAldea.enabled == true)
            {
                
            }
            return;
        }

        if (actual == "LlaveEstablo")
        {
            if (LlaveEstablo.enabled == true)
            {
                
            }
            return;
        }

        if (actual == "LlaveMansion")
        {
            if (LlaveMansion.enabled == true)
            {
                
            }
            return;
        }

        if (actual == "LlaveAlmacen")
        {
            if (LlaveAlmacen.enabled == true)
            {
                
            }
            return;
        }

        if (actual == "LlaveAldea")
        {
            if (LlaveAldea.enabled == true)
            {
                
            }
            return;
        }

        if (actual == "VidaEstablo")
        {
            if(VidaEstablo.enabled == true)
            {
                healthBar.AddHealth(15);
            }
            //adminScript.btn_uVida3();
            return;
        }

        if (actual == "VidaMansion")
        {
            if (VidaMansion.enabled == true)
            {
                healthBar.AddHealth(20);
            }
            //adminScript.btn_uVida4();
            return;
        }

        if (actual == "VidaAldea")
        {
            if (VidaAldea.enabled == true)
            {
                healthBar.AddHealth(5);
            }
            //adminScript.btn_uVida1();
            return;
        }

        if (actual == "VidaAlmacen")
        {
            if (VidaAlmacen.enabled == true)
            {
                healthBar.AddHealth(10);
            }
            //adminScript.btn_uVida2();
            return;
        }
    }
}
