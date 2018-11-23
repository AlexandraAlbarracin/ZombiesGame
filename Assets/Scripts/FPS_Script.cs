using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.SqlClient;
using UnityEngine.VR;
using System;

public class FPS_Script : MonoBehaviour
{
    // Use this for initialization
    public GameObject zombie1;
    System.Timers.Timer timer;
    System.ComponentModel.BackgroundWorker worker;

    float x;
    float y;
    float z;
    void Start()
    {
        worker = new System.ComponentModel.BackgroundWorker();
        worker.DoWork += Worker_DoWork;
        worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        worker.RunWorkerAsync();
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

        pos = ActualizarPosicionServidor(x, y, z);
        servidor = true;
        //Posicion pos = ActualizarPosicionServidor(x, y, z);
        //if (pos.zombie)
        //{
        //    zombie1.SetActive(false);
        //    zombie1.transform.position = new Vector3(0, -19, 60);
        //    zombie1.SetActive(true);
        //}
    }

    //bool bd = false;
    // Update is called once per frame
    void Update()
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

        //if (!bd)
        //{
        //    ActualizarPosicionServidor(transform.position.x, transform.position.y, transform.position.z);
        //    bd = true;
        //}
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        if (servidor)
        {

            if (pos.zombie)
            {
                //zombie1.SetActive(false);
                //zombie1.transform.position = new Vector3(0, -19, 60);
                //zombie1.transform.position = new Vector3(19, -27.38f, -104);
                //System.Random rnd = new System.Random();
                //int _x = rnd.Next(0, 40);
                //int _z = rnd.Next(30, 60);
                //zombie1.transform.position = new Vector3((float)pos.x + 20, -27.38f, (float)pos.z - 30);
                //zombie1.transform.position = new Vector3((float)pos.x + _x, -27.38f, (float)pos.z - _z);
                zombie1.transform.position = new Vector3((float)pos.x , -20f, (float)pos.z);
                zombie1.SetActive(true);
            }
            servidor = false;
        }
    }
    //create table Posicion(ID int not null Primary key identity,x decimal(18,2) not null,y decimal(18,2)not null,z decimal(18,2)not null,Zombie bit not null,TipoZombie int not null, Vida int not null,Mujer bit not null)
    //create table Posicion(ID int not null Primary key identity,x decimal(18,2) not null,y decimal(18,2)not null,z decimal(18,2)not null,Zombie bit not null)
    //20 en x, -50 en z
    public void RevisarServidor()
    {
        Posicion pos = ObtenerPosicionServidor();
        if (pos.zombie)
        {
            zombie1.SetActive(false);
            //zombie1.transform.position = new Vector3(0, -19, 60);
            //zombie1.transform.position = new Vector3((float)pos.x + 20, -27.38f, (float)pos.z - 30);

            zombie1.SetActive(true);
        }
    }
    SqlConnection conn;
    public void Conectar()
    {
        if(conn == null)
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
    public Posicion ActualizarPosicionServidor(double x, double y, double z)
    {
        Conectar();
        Posicion posicion = new Posicion();
        try
        {
            SqlCommand cmd = new SqlCommand("update Posicion set x = " + x + ", y = " + y + ",z = " + z + " where ID = 1", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("select * from Posicion where ID = 2", conn);

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    posicion.x = (Convert.ToDouble(rdr["x"]));
                    posicion.y = (Convert.ToDouble(rdr["y"]));
                    posicion.z = (Convert.ToDouble(rdr["z"]));
                    posicion.zombie = (Convert.ToBoolean(rdr["Zombie"]));
                    posicion.tipozombie = (Convert.ToInt32(rdr["TipoZombie"]));
                }
            }
            Debug.Log("x: " + posicion.x + "y: " + posicion.y + " z: " + posicion.z);
            return posicion;
        }
        catch (SqlException e)
        {
            Debug.Log("Error actualizando servidor: " + e.Message);
            return posicion;
        }
    }
    public Posicion ObtenerPosicionServidor()
    {
        Conectar();
        Posicion posicion = new Posicion();
        try
        {
            SqlCommand cmd = new SqlCommand("select * from Posicion", conn);

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    posicion.x = (Convert.ToDouble(rdr["x"]));
                    posicion.y = (Convert.ToDouble(rdr["y"]));
                    posicion.z = (Convert.ToDouble(rdr["z"]));
                    posicion.zombie = (Convert.ToBoolean(rdr["Zombie"]));
                    posicion.tipozombie = (Convert.ToInt32(rdr["TipoZombie"]));
                }
            }
            Debug.Log("x: " + posicion.x + "y: " + posicion.y + " z: " + posicion.z);
            return posicion;
        }
        catch (SqlException e)
        {
            Debug.Log("Error obteniendo servidor: " + e.Message);
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
    }
}
