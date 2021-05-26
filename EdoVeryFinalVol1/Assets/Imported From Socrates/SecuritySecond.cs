using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuritySecond : MonoBehaviour
{
    public GameObject ThePaper;
    public bool paperIsSigned;
    public Conversation secondSecurityNegative;
    public Conversation thirdSecurityNegative;
    //public Conversation firstSecurityPositive;


    void OnTriggerEnter()
    {
        if (ThePaper.active==true)
        {
            TheDialogueManager.StartConversation(secondSecurityNegative);

        }

        if (ThePaper.active == false)
        {
            TheDialogueManager.StartConversation(thirdSecurityNegative);

        }
/*
        if (ThePaper.active == false && paperIsSigned)
        {
            TheDialogueManager.StartConversation(firstSecurityPositive);

        }

    */

    }
}
