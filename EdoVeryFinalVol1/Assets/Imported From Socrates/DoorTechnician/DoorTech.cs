/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTech : MonoBehaviour
{
   // public Collider TechDoor;
    public Conversation techConversation;
    public Animator techDoorAnim;
    public Collider TechDoor;
    public TalkedToBoss talkedToBoss;
   

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider TechDoor)
    {
        TheDialogueManager.StartConversation(techConversation);

       // if (TalkedToBoss.talkedWithBoss)
      //  { 

            if (TechDoor.tag == "Player")
            {
            techDoorAnim = GetComponent<Animator>();

            techDoorAnim.SetInteger("DoorOpens", 1);

            }
       // }
       // }
    }
    
}
*/
