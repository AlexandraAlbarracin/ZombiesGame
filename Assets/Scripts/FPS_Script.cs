using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class FPS_Script : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        //var angles = InputTracking.GetLocalRotation(VRNode.CenterEye);
        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z);
        // float rotation = Input.GetAxis("Rotate");
        //rotation *= Time.deltaTime;
        //transform.Rotate(0, rotation, 0);
        //Debug.Log(transform.rotation.x + "," + transform.rotation.y+","+ transform.rotation.z);

        if (Input.GetKey(KeyCode.F))
        {
            transform.position += transform.forward / 2;//Vector3
        }
        if (Input.GetKey(KeyCode.V))
        {
            transform.position += -transform.forward / 2;
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.position += -transform.right / 2;
        }
        if (Input.GetKey(KeyCode.B))
        {
            transform.position += transform.right / 2;
        }

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
