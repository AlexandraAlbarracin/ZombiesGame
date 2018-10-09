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
    // Use this for initialization
    void Start ()
    {

        //ActualizarArma(4);
	}
	
	// Update is called once per frame
	void Update ()
    {
        //"joystick 1 button 0" cuadrado
        //"joystick 1 button 1" x
        //"joystick 1 button 2" circulo
        //"joystick 1 button 3" triangulo
        if (Input.GetKeyDown("joystick 1 button 1"))
        {
            Debug.Log("boton x");
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
}
