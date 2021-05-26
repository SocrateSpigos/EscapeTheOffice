/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraSwitch : MonoBehaviour
{
    public Collider Chair;
    public Camera FpsCam;
    public Camera TpsCam;
    bool fpsCam = true;
    // Start is called before the first frame update
    void Start()
    {
        FpsCam.enabled = fpsCam;
        TpsCam.enabled = !fpsCam;
    }

    // Update is called once per frame
   void Update()
    {
        void OnTriggerEnter(Collider col)
        {
            if (col.tag == "Player")
            {
                fpsCam = !fpsCam;
                FpsCam.enabled = fpsCam;
                TpsCam.enabled = !fpsCam;
            }
        } //prossesing
                   
    }
}
*/