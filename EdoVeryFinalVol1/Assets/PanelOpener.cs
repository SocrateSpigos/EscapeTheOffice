using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public TheDialogueManager thedialoguemanager;
    public Collider secondCollider;
    public Animator _animator;
    public GameObject OpenPanel = null;
    public Conversation noSandwichConversation;
    bool isInConversation = false;



    void OnTriggerEnter(Collider secondCollider)
    {
        Debug.Log("OHWEE");
        void OnConversationStart(Transform noSandwichConversation)
        {
            isInConversation = true;
        }


        void OnConversationEnd(Transform noSandwichConversation)
        {
            Debug.Log("KIKIKIKI");

            OpenPanel.SetActive(true);
        }

    }

    

    /*  void OpenThatPanel()
      {
          if (thedialoguemanager.openThePanel == true)
          {
              OpenPanel.SetActive(true);
          }

          if (Input.GetKeyDown(KeyCode.E))
          {
              OpenPanel.SetActive(false);
              _animator.SetBool("Open", true);
              _animator.SetBool("Close", false);
          }
      }*/

}
