/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactvateBossDialogue : MonoBehaviour
{
    
    public GameObject FirstBossDialogueTrigger;
    public GameObject SecondBossDialogueTrigger;

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

    public Collider triggerCollider;


    public void Awake()
    {
    }
        void OnTriggerEnter(Collider triggerCollider)
        {
            KnockPanel.SetActive(true);

        }


        void OnTriggerStay(Collider triggerCollider)
        {
            Debug.Log("OOOO");


            if (Input.GetKeyDown(KeyCode.Z))
            {
       

                if (sandwich.active == false)
                {

                    KnockPanel.SetActive(false);

                
                    //TheDialogueManager.StartConversation(sandwichConversation);


                    techDoorAnim.SetInteger("DoorOpens", 1);

                    openDoorbool = true;
                    FirstBossDialogueTrigger.SetActive(false);
                    SecondBossDialogueTrigger.SetActive(true);
                    Destroy(TechDoor);
                }
                 else
                {
                    KnockPanel.SetActive(false);

                    TheDialogueManager.StartConversation(noSandwichConversation);
                }
            }

        }
    

    void OnTriggerExit(Collider triggerCollider)
    {
        if (triggerCollider.tag == "Player")
        {
           // FirstBossDialogueTrigger.SetActive(false);
           // SecondBossDialogueTrigger.SetActive(true);
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

    void Update()
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
    }
}

*/