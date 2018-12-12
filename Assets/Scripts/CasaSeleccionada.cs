using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasaSeleccionada : MonoBehaviour {

    public string elegido;

    public GameObject btnAldea;
    public GameObject btnAlmacen;
    public GameObject btnCasaAldea;
    public GameObject btnCasaLago;
    public GameObject btnCementerio;
    public GameObject btnEstablo;
    public GameObject btnLago;
    public GameObject btnMansion;

    public void Start () {
        elegido = AdminJugador2.elegido;
        pintar();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pintar()
    {
        if(elegido == "btnAldea")
        {
            var n = btnAldea.GetComponent<Image>();
            n.color = Color.yellow;
            return;
        }

        if (elegido == "btnAlmacen")
        {
            var n = btnAlmacen.GetComponent<Image>();
            n.color = Color.yellow;
            return;
        }

        if (elegido == "btnCasaAldea")
        {
            var n = btnCasaAldea.GetComponent<Image>();
            n.color = Color.yellow;
            return;
        }

        if (elegido == "btnCasaLago")
        {
            var n = btnCasaLago.GetComponent<Image>();
            n.color = Color.yellow;
            return;
        }

        if (elegido == "btnCementerio")
        {
            var n = btnCementerio.GetComponent<Image>();
            n.color = Color.yellow;
            return;
        }

        if (elegido == "btnEstablo")
        {
            var n = btnEstablo.GetComponent<Image>();
            n.color = Color.yellow;
            return;
        }

        if (elegido == "btnLago")
        {
            var n = btnLago.GetComponent<Image>();
            n.color = Color.yellow;
            return;
        }

        if (elegido == "btnMansion")
        {
            var n = btnMansion.GetComponent<Image>();
            n.color = Color.yellow;
            return;
        }
    }
}
