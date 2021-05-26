using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterScript : MonoBehaviour
{

    public Collider printer;
    public Animator printerAnim;
    public Camera PrinterCam;
    public Camera TpsCam;


    public void Awake()
    {
        
        PrinterCam.enabled = false;
    }

    void OnTriggerEnter(Collider printer)
    {
        if (printer.tag == "Player")
        {
            printerAnim = GetComponent<Animator>();

            TpsCam.enabled = false;
            PrinterCam.enabled = true;


        /*    if (Input.GetKeyDown(KeyCode.Q))
            {
                printerAnim.SetInteger("Qpressed", 1);

            }
            */

        }

    }

    

    void OnTriggerStay(Collider printer)
    {
        if (printer.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                printerAnim.SetInteger("Qpressed", 1);


            }

        }
    }

    void OnTriggerExit(Collider printer)
    {
        TpsCam.enabled = true;
        PrinterCam.enabled =false;
    }


}