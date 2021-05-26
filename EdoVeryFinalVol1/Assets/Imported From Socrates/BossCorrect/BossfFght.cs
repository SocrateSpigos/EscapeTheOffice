using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossfFght : MonoBehaviour
{
    TechnicianScript technicianScript;

    public GameObject ThePaper;
    public bool paperIsSigned = false;

    public Conversation talkToBoss;
    public Conversation signThePaperPlz;

    void OnTriggerEnter()
    { 
            TheDialogueManager.StartConversation(talkToBoss);
    }
}
