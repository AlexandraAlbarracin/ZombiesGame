using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;

public class Zombie1Script : MonoBehaviour {

	public Transform zombie1SpawnPoints; // The parent of the spawn points
	public bool reSpawn = false;
	
	private Transform[] spawnPoints;
	private bool lastToggle = false;

    public GameObject jugador;

    public HealthBar healthBar; 

    System.ComponentModel.BackgroundWorker worker;
    System.Timers.Timer timer;

    // Use this for initialization
    void Start () {
		spawnPoints = zombie1SpawnPoints.GetComponentsInChildren<Transform> ();

        worker = new System.ComponentModel.BackgroundWorker();
        worker.DoWork += Worker_DoWork;
        worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        worker.RunWorkerAsync();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (lastToggle != reSpawn)
        {
			Respawn ();
			reSpawn = false;
		}
        else
        {
			lastToggle = reSpawn;
		}
        x_jugador = (int)jugador.transform.position.x;
        z_jugador = (int)jugador.transform.position.z;
        x_zombie = (int)transform.position.x;
        z_zombie = (int)transform.position.z;

        //if (isInside((int)jugador.transform.position.x, (int)jugador.transform.position.z, 1, (int)transform.position.x, (int)transform.position.z))
        //{
        //    danio += 2;
        //    Debug.Log("Jugador herido ................" + danio);
        //}
    }
	private void Respawn() {
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}

    int danio = 0;
    int x_jugador = 0;
    int z_jugador = 0;
    int x_zombie = 0;
    int z_zombie = 0;
    bool isInside(int circle_x, int circle_y, int rad, int x, int y)
    { 
        if ((x - circle_x) * (x - circle_x) +
            (y - circle_y) * (y - circle_y) <= rad * rad)
            return true;
        else
            return false;
    }
    private void Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {

    }

    private void Worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        timer = new System.Timers.Timer();
        timer.Elapsed += Timer_Elapsed;
        timer.Interval = 1000;
        timer.Enabled = true;
    }
    private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        if (isInside(x_jugador, z_jugador, 1, x_zombie, z_zombie))
        {
            danio += 3;
            healthBar.AddHealth(-3);
            Debug.Log("Jugador herido ................" + danio);
        }
        if (danio > 10)
            ActualizarPosicionServidor();


    }
    SqlConnection conn;
    public void Conectar()
    {
        conn = new SqlConnection("Data Source=DBTests.mssql.somee.com;user id=Edward_1_SQLLogin_1;pwd=3iobta3f1h;Initial Catalog=DBTests;");
        try
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open(); //PlayerPrefs.set("Player Name", "Foobar");
        }
        catch (SqlException e)
        {
            Debug.Log("Error en conexion a servidor: " + e.Message);
        }
    }
    public void ActualizarPosicionServidor()
    {
        Conectar();
        try
        {
            SqlCommand cmd = new SqlCommand("update Posicion set Vida -= " +danio+" where ID = 1", conn);
            cmd.ExecuteNonQuery();
            Debug.Log("Vida de  jugador actualizada");
            danio = 0;
        }
        catch (SqlException e)
        {
            Debug.Log("Error actualizando servidor: " + e.Message);
        }
    }
}
