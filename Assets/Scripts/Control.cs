using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System;
using UnityEngine.UI;

public class Control : MonoBehaviour {

	public void cambiarescena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
