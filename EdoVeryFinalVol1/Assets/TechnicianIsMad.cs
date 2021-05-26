using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TechnicianIsMad : MonoBehaviour
{

    public Collider technicianIsMad;
    public Conversation techIsMad;


        void OnTriggerEnter(Collider TechnicianIsMad)
        {

           if (TechnicianIsMad.tag == ("Technician"))
           {

            TheDialogueManager.StartConversation(techIsMad);

           }
        }

}
