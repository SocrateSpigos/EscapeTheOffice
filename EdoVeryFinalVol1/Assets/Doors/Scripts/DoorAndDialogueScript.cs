using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorAndDialogueScript : MonoBehaviour
{
    public GameObject OpenPanel = null;
    public GameObject KnockPanel = null;

    private bool _isInsideTrigger = false;

    public Animator _animator;

    public Conversation noSandwichConversation;

    public Conversation sandwichConversation;

    public GameObject sandwich;


    public bool openDoorbool = false;

    public Animator techDoorAnim;

    public Collider TechDoor;

    public Conversation techConversation;

    public TheDialogueManager thedialoguemanager;

    


    void OnTriggerEnter(Collider other)
    {
        if (TechDoor.tag == ("Player"))
        {
            _isInsideTrigger = true;
            TheDialogueManager.StartConversation(techConversation);


        }

        if (other.tag == ("Player") && KnockPanel != null)
        {                       
            _isInsideTrigger = true;
            //OpenPanel.SetActive(true);
            KnockPanel.SetActive(false);
           
        }
        if (other.tag == ("Player") && OpenPanel != null)
        {
            _isInsideTrigger = true;
            OpenPanel.SetActive(false);
            KnockPanel.SetActive(true);
        }

     /*   if (other.tag == ("Boss"))
        {
            OpenPanel.SetActive(false);
            KnockPanel.SetActive(false);
            _animator.SetBool("Open", true);
            _animator.SetBool("Close", false);
        }
        if (other.tag == ("Technician"))
        {
            _animator.SetBool("Open", true);
            _animator.SetBool("Close", false);
        }
        */
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player") || other.tag == ("Boss") || other.tag == ("Technician"))
        {
            _isInsideTrigger = false;
            _animator.SetBool("Open", false);
            _animator.SetBool("Close", true);
            OpenPanel.SetActive(false);
            KnockPanel.SetActive(false);
            //TheDialogueManager.CloseDialogue();
        }
    }
    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }
    private bool IsKnockPanelActive
    {
        get
        {
            return KnockPanel.activeInHierarchy;
        }
    }


    public void StartConvo()
    {
        TheDialogueManager.StartConversation(noSandwichConversation);
    }
    // Update is called once per frame
    public void Update()
    {

        if (IsOpenPanelActive && _isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OpenPanel.SetActive(false);
                _animator.SetBool("Open", true);
                _animator.SetBool("Close", false);
            }


        }
        
        if (IsKnockPanelActive && _isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (sandwich.active == false)
                {


                    Destroy(TechDoor);

                    techDoorAnim.SetInteger("DoorOpens", 1);

                    TheDialogueManager.StartConversation(sandwichConversation);


                    openDoorbool = true;

                    SuspiciousMeter.currentSuspiciousMeter += 10;
                    Debug.Log("suspious");

                }
                else
                {
                    TheDialogueManager.StartConversation(noSandwichConversation);
                }
                KnockPanel.SetActive(false);
               // if(openDoorbool == true && thedialoguemanager.openThePanel == true)
              //  {
               //     OpenPanel.SetActive(true);
              //  }
               
            }
        }
    }

   
}
