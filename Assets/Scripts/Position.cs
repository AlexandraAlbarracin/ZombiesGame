using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Position : MonoBehaviour {

    public GameObject terreno;
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (terreno.GetComponent<Collider>().Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.point.x + " " + hit.point.z);
            }
        }
    }
    
}