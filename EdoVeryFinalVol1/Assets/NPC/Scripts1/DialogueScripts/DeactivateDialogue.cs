using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateDialogue : MonoBehaviour
{
    public GameObject FirstDialogueTrigger;
    public GameObject SecondDialogueTrigger;


    public Collider triggerCollider;

    public void Awake()
    {
        if (triggerCollider.tag == "Player")
        {

            SecondDialogueTrigger.SetActive(false);
            FirstDialogueTrigger.SetActive(true);
        }
    }


    void OnTriggerExit(Collider triggerCollider)
    {
        if (triggerCollider.tag == "Player")
        {
            FirstDialogueTrigger.SetActive(false);
            SecondDialogueTrigger.SetActive(true); 

             
        }
    }
    
}
