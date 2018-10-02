using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarTerrenoScript : MonoBehaviour
{

    public GameObject fpsController;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void HabilitarFps()
    {
        fpsController.SetActive(true);
    }
}
