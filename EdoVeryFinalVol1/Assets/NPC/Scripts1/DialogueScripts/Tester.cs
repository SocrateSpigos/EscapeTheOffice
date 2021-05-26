using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{

    public Conversation convo;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            TheDialogueManager.StartConversation(convo);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            TheDialogueManager.CloseDialogue();
        }
    }
    public void StartConvo()
    {
        TheDialogueManager.StartConversation(convo);

    }
}
