using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class vehicleEntry : MonoBehaviour
{
    public GameObject vehicleCam;
    public GameObject thePlayer;
    public GameObject liveVehicle;
    public bool canEnter = false;

    void Update()
    {
        if (canEnter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                vehicleCam.SetActive(true);
                thePlayer.SetActive(false);
                liveVehicle.GetComponent<CarController>().enabled = true;
                liveVehicle.GetComponent<CarUserControl>().enabled = true;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canEnter = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        canEnter = false;
    }

}