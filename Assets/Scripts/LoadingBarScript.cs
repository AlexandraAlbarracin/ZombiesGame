using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBarScript : MonoBehaviour
{
    public GameObject cnv;
     
    Slider sldProgreso;
    VisionRaycast VisionScript;
    public Estado_Seleccion Estado;
    public float time;
    public float time_max = 1;

	// Use this for initialization
	void Start ()
    {
        Estado = Estado_Seleccion.NoSeleccionado;
        sldProgreso = GameObject.Find("sldProgreso").GetComponent<Slider>(); ;
        sldProgreso.maxValue = time_max;
        //Debug.Log("++++++++++++" + time.ToString());
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Estado == Estado_Seleccion.Seleccionando)
        {
            time += Time.deltaTime;
            if (time < time_max)
            {
                sldProgreso.value = time;
                //Debug.Log("++++++++++++" + time.ToString());
            }
            if (time >= time_max)
                Estado = Estado_Seleccion.Seleccionado;
        }
        if(Estado == Estado_Seleccion.NoSeleccionado)
        {
            time = 0;
            sldProgreso.value = time;
        }
    }
    //float CalcularProgreso()
    //{
    //    return progreso_actual / maximo;
    //}
}
public enum Estado_Seleccion
{
    Seleccionando,
    Seleccionado,
    NoSeleccionado
}
