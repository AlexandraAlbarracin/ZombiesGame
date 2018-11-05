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

    // Use this for initialization
    void Start ()
    {

        //ActualizarArma(4);
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
        {
            submenu = !submenu;
            canvassubmenu.SetActive(submenu);
            //Debug.Log("boton x");
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
}
