using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBarScript : MonoBehaviour
{
    //public GameObject cnv;

    //AdminScript adminScript;
    public Slider sldProgreso;
    //VisionRaycast VisionScript;
    //public Estado_Seleccion Estado;
    public float time;
    public float time_max = 3;

	// Use this for initialization
	void Start ()
    {
        //Estado = Estado_Seleccion.NoSeleccionado;
        sldProgreso = GameObject.Find("sldProgreso").GetComponent<Slider>(); 
        sldProgreso.maxValue = time_max;
        //Debug.Log("++++++++++++" + time.ToString());
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("#----------- " + PlayerPrefs.GetString("Estado"));
        string est = PlayerPrefs.GetString("Estado");
        if (est == Estado_Seleccion.Seleccionando.ToString())
        {
            //Debug.Log("time_ ");
            time += Time.deltaTime;

            if (time < time_max)
            {
                sldProgreso.value = time;
                //Debug.Log("sldProgreso.value " + sldProgreso.value.ToString());
            }

            if (time >= time_max)
            {
                //Estado = Estado_Seleccion.Seleccionado;
                PlayerPrefs.SetString("Estado", "Seleccionado");
                //Debug.Log("time_max " + time.ToString());
            }


        }

        if(est == Estado_Seleccion.NoSeleccionado.ToString())
        {
            time = 0;
            sldProgreso.value = time;
            Variables.btn = -1; PlayerPrefs.SetString("btn", "-1");
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
