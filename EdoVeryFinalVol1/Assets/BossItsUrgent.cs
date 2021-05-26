using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossItsUrgent : MonoBehaviour
{
    public Collider urgent;
    public GameObject OpenPanel = null;
    public GameObject KnockPanel = null;

    public GameObject SignThisPlz;

    public Animator _animator;
    public bool openDoorbool = false;
    private bool _isInsideTrigger = false;
    public Conversation paperConversation;



    public void Awake()
    {
        SignThisPlz.SetActive(false);

    }

    void OnTriggerEnter(Collider urgent)
    {
        if (urgent.tag == ("Player") && KnockPanel != null)
        {
            _isInsideTrigger = true;
            KnockPanel.SetActive(false);

        }
        if (urgent.tag == ("Player") && OpenPanel != null)
        {
            _isInsideTrigger = true;
            OpenPanel.SetActive(false);
            KnockPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider urgent)
    {
        if ((urgent.tag == ("Player") || urgent.tag == ("Boss") || urgent.tag == ("Technician")))
        {
            _isInsideTrigger = false;
            _animator.SetBool("Open", false);
            _animator.SetBool("Close", true);
            OpenPanel.SetActive(false);
            KnockPanel.SetActive(false);
            //deTheDialogueManager.CloseDialogue();
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

    public void Update()
    {

        if (IsOpenPanelActive && _isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SignThisPlz.SetActive(true);
                OpenPanel.SetActive(false);
                _animator.SetBool("Open", true);
                _animator.SetBool("Close", false);


            }


        }

        if (IsKnockPanelActive && _isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {             
                    TheDialogueManager.StartConversation(paperConversation);

                    openDoorbool = true;
                           
                    KnockPanel.SetActive(false);
               

            }
        }
    }
}