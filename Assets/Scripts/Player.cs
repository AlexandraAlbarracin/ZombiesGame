using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Image imageUI;
    public bool sexo;
	// Use this for initialization
	void Start () {
        imageUI = GameObject.Find("Jugador").GetComponent<Image>();
        sexo = AdminScript.sexo;

        if (sexo == false)
        {
            imageUI.sprite = Resources.Load<Sprite>("Image/hombre");
        }

        if (sexo == true)
        {
            imageUI.sprite = Resources.Load<Sprite>("Image/mujer");
        }
    }

}
