using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMover : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent navmeshagent;
    Queue<Vector3> puntos_ruta = new Queue<Vector3>();
    // Use this for initialization
    private void Awake()
    {
        //navmeshagent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //FindObjectOfType<PathCreator>().newpath += SetPoints;
    }
    private void SetPoints(IEnumerable<Vector3> puntos)
    {
        puntos_ruta = new Queue<Vector3>(puntos);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //ActualizarRuta();
        if (posicionactual < this.Puntos.Length)
        {
            if (PuntoObjetivo == null)
                PuntoObjetivo = Puntos[posicionactual];
            Caminar();
        }
    }
    void ActualizarRuta()
    {
        if (AsignarDestino())
            navmeshagent.SetDestination(puntos_ruta.Dequeue());
    }
    bool AsignarDestino()
    {
        if (puntos_ruta.Count == 0)
            return false;
        if (navmeshagent.hasPath == false || navmeshagent.remainingDistance < 0.5f)
            return true;
        return false;
    }

  
    public Transform[] Puntos;

    public int posicionactual = 0;
    Transform PuntoObjetivo;

    public float speed = 4f;
    void Caminar()
    {
        //rotacion
        transform.forward = Vector3.RotateTowards(transform.forward, PuntoObjetivo.position - transform.position, speed * Time.deltaTime, 0.0f);

        // posicion
        transform.position = Vector3.MoveTowards(transform.position, PuntoObjetivo.position, speed * Time.deltaTime);

        if (transform.position == PuntoObjetivo.position)
        {
            posicionactual++;
            if (posicionactual + 1 > Puntos.Length)
                posicionactual = 0;
            PuntoObjetivo = Puntos[posicionactual];
        }
    }
}
