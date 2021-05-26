using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SecurityReactions : MonoBehaviour
{
   // public GameObject FakePaper;
    public GameObject securityGuy1;
    public GameObject securityGuy2;
    public Animator securityAnim;
    public Conversation securityConverasation;

    public Button security1;
    public Button security2;
    public Button security3;

    public void Start()
    {
        Button btn1 = security1.GetComponent<Button>();
        btn1.onClick.AddListener(ButtonPressed);

        Button btn2 = security2.GetComponent<Button>();
        btn2.onClick.AddListener(ButtonPressed);

        Button btn3 = security3.GetComponent<Button>();
        btn3.onClick.AddListener(ButtonPressed);

    }

    public void ButtonPressed()
    {
        securityGuy1.SetActive(false);
        securityGuy2.SetActive(true);

    }

    public void OnTriggerEnter(Collider securityGuy)
    {
        if (securityGuy.tag == "Player")
        {

            securityAnim.SetInteger("Condition", 1);

            TheDialogueManager.StartConversation(securityConverasation);

            Debug.Log("HAHAHAHA");
        }
    }

    public void OnTriggerExit(Collider securityGuy)
    {
        securityAnim.SetInteger("Condition", 0);
        
        
    }

}