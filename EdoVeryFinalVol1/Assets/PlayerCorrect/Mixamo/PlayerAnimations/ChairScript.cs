using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairScript : MonoBehaviour
{
    //public GameObject character;
    CharacterController controller;
    //bool isInsideChairTrigger = false;
    public Collider Chair;
    public Animator chairAnim;
    public Animator anim;
    public Animator camAnim;
    public Animator screenPlay;
    //public GameObject OpenPanel = null;


    public Camera FpsCam;
    public Camera TpsCam;
    bool fpsCam = true;
   // bool tpsCam = true;

    //bool canMove = true;

    public void Start()
    {
        // FpsCam.enabled = !fpsCam;
        // TpsCam.enabled = fpsCam;

        TpsCam.enabled = true;
        FpsCam.enabled = false;

    }




    // Start is called before the first frame update
    /* void OnTriggerEnter(Collider col)
     {
         if (col.tag == "Player")
         {
             chairAnim = GetComponent<Animator>();

             chairAnim.SetInteger("SitDown", 1);

             if (Input.GetKeyDown(KeyCode.Q))
             {
                 // PlayerController moveScript = col.GetComponent<PlayerController>();

                 // moveScript.canMove = false;


                 //anim.SetInteger("Condition1", 3);
                // camAnim.SetInteger("IsSitting", 1);
                // screenPlay.SetInteger("ScreenIsOn", 1);

                 //fpsCam = !fpsCam;
                 //FpsCam.enabled = fpsCam;
                 //TpsCam.enabled = !fpsCam;
                 //  if (Input.GetKey(KeyCode.Q))
                 // {
                 //   anim = GetComponent<Animator>();
                 Debug.Log("Enter");

                 //  }


             }

         }
     }
     */

    void OnTriggerExit(Collider col)
        {
            if (col.tag == "Player")
            {
            TpsCam.enabled = false;
            FpsCam.enabled = true;
            // PlayerController moveScript = col.GetComponent<PlayerController>();

            // moveScript.canMove = true;

            //   screenPlay.SetInteger("ScreenIsOn", 0);

            //anim = GetComponent<Animator>();
            // camAnim.SetInteger("IsSitting", 0);

            //    anim.SetInteger("Condition1", 0);
            chairAnim = GetComponent<Animator>();
                chairAnim.SetInteger("SitDown", 0);

            //fpsCam = !fpsCam;
              //  FpsCam.enabled = fpsCam;
                //TpsCam.enabled = !fpsCam;




            }
        }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            chairAnim = GetComponent<Animator>();
            chairAnim.SetInteger("SitDown", 1);

            if (Input.GetKeyDown(KeyCode.Z))
            {
               
                camAnim.SetInteger("IsSitting", 2);
                screenPlay.SetInteger("ScreenIsOn", 0);

                StartCoroutine(Wait());

               

            }



            if (Input.GetKeyDown(KeyCode.Q))
            {
                camAnim.SetInteger("IsSitting", 1);

                screenPlay.SetInteger("ScreenIsOn", 1);

                //anim = GetComponent<Animator>();

                anim.SetInteger("Condition1", 0);
                chairAnim = GetComponent<Animator>();
                chairAnim.SetInteger("SitDown", 0);

                TpsCam.enabled = true;
                FpsCam.enabled = false;




            }

        }

    }
   
    /* if (Input.GetKeyDown(KeyCode.Q)&& isInsideChairTrigger)
     {
         // PlayerController moveScript = col.GetComponent<PlayerController>();

         //  moveScript.canMove = false;
         //anim.SetInteger("Condition1", 3);
         camAnim.SetInteger("IsSitting", 0);
         screenPlay.SetInteger("ScreenIsOn", 0);
         fpsCam = !fpsCam;
         FpsCam.enabled = fpsCam;
         TpsCam.enabled = !fpsCam;
       isInsideChairTrigger = false;


   }*/

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.8f);
        FpsCam.enabled = true;
        TpsCam.enabled = false;
        //fpsCam = !fpsCam;  
        //FpsCam.enabled = fpsCam; 
        //TpsCam.enabled = !fpsCam;
        Debug.Log("WaitIsOver");
    }
}
       
