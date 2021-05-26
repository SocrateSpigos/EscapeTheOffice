using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPc : MonoBehaviour
{
    BreakProjector breakProjector;
    TechnicianScript technicianScript;

    public Collider PC;
    public GameObject Technician;
    void Start()
    {
    }
    void OnTriggerEnter(Collider PC)
    {
        if (PC.gameObject.CompareTag("Technician"))
        {
            Update();
        }
    }

    //FAILED
    /* void OnCollisionEnter(Collider PC)
    {
        if (PC.gameObject.name == "Technician")
        {
            Debug.Log("WERE IN");

        }
    }
    public void OnTriggerEnter(Collider PC)
    {
        if (PC.tag == "Technician")
        {
            Debug.Log("mpike");
        }

        

    }        */

    // Update is called once per frame
    void Update()
    {
        if (technicianScript.buttonPressed)
        {

            Debug.Log("WERE IN");
        }
    }
}

