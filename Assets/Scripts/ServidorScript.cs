using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using UnityEngine;
using UnityEngine.UI;

public class ServidorScript : MonoBehaviour {
    public GameObject terreno;
    public Transform playerTransform;
    System.Timers.Timer timer;
    System.ComponentModel.BackgroundWorker worker;
    float x;
    float y;
    float z;

    public Image imageUI;
    public static bool sexo; 
    // Use this for initialization
    void Start () {
        worker = new System.ComponentModel.BackgroundWorker();
        worker.DoWork += Worker_DoWork;
        worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        worker.RunWorkerAsync();
        sexo = false;
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
    bool servidor = false;
    Posicion pos;
    private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {

        pos = ActualizarPosicionServidor(x, y, z,ControladorJuego.tipo_zombie);
        servidor = true;

    }
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (terreno.GetComponent<Collider>().Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.point.x + " " + hit.point.z);
                x = hit.point.x;
                z = hit.point.z;
            }
        }
        if (servidor)
        {
            playerTransform.position = new Vector3((float)pos.x, (float)pos.y, (float)pos.z);
            sexo = pos.mujer;
        }
    }

    SqlConnection conn;
    public void Conectar()
    {
        if (conn == null)
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
    public Posicion ActualizarPosicionServidor(double x, double y, double z, int tipo)
    {
        Conectar();
        Posicion posicion = new Posicion();
        try
        {
            SqlCommand cmd = new SqlCommand("update Posicion set x = " + x + ", y = " + y + ",z = " + z + ", TipoZombie = " + tipo + " where ID = 2", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("select * from Posicion where ID = 1", conn);

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    posicion.x = (Convert.ToDouble(rdr["x"]));
                    posicion.y = (Convert.ToDouble(rdr["y"]));
                    posicion.z = (Convert.ToDouble(rdr["z"]));
                }
            }
/*cosita redonda*/
           Debug.Log("x: " + posicion.x + "y: " + posicion.y + " z: " + posicion.z);
            return posicion;
        }
        catch (SqlException e)
        {
            Debug.Log("Error actualizando servidor: " + e.Message);
            return posicion;
        }
    }
    public class Posicion
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public bool zombie { get; set; }
        public int tipozombie { get; set; }
        public bool mujer { get; set; }
    }
}
