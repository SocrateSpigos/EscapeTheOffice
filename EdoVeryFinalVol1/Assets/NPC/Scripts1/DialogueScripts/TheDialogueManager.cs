using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TheDialogueManager : MonoBehaviour
{

    public TextMeshProUGUI speakerName, dialogue, navButtonText; // option1, option2;
    public Image speakerSprite;
    public GameObject option1;
    public GameObject option2;
    public GameObject option1Projector;
    public GameObject option2Projector;

    public GameObject TalkToBoss1;
    public GameObject TalkToBoss2;
    public GameObject TalkToBoss3;

    public GameObject TalkToSecurity1;
    public GameObject TalkToSecurity2;
    public GameObject TalkToSecurity3;

    public Animator bossAnim;
    public Animator freedom;

    public GameObject SecurityLetsYou;
    public GameObject SecuritySecond;






    public GameObject openPanel;
    public GameObject doorKnock;
    public GameObject NotSigned;
    public GameObject SecurityNegative;


    private int currentIndex;
    private Conversation currentConvo;
    private static TheDialogueManager instance;
    private Animator anim;
    private Coroutine typing;
    public bool openThePanel = false;


    private void Awake()
    {
        Button btn1 = TalkToBoss1.GetComponent<Button>();
        btn1.onClick.AddListener(BossButtonPressed1);

        Button btn2 = TalkToBoss2.GetComponent<Button>();
        btn2.onClick.AddListener(BossButtonPressed2);

        Button btn3 = TalkToBoss3.GetComponent<Button>();
        btn3.onClick.AddListener(BossButtonPressed1);


        option1.SetActive(false);
        option2.SetActive(false);


        if (instance == null)
        {
            instance = this;
            anim = GetComponent<Animator>();

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void BossButtonPressed1()
    {
        bossAnim.SetInteger("BossDoesStuff", 1);

    }

    public void BossButtonPressed2()
    {
        bossAnim.SetInteger("BossDoesStuff", 2);

    }

    private void Update()
    {
        if (instance.dialogue.text == "...")
        {
            TalkToSecurity1.SetActive(true);
            TalkToSecurity2.SetActive(true);
            TalkToSecurity3.SetActive(true);
        }
        else
        {
            TalkToSecurity1.SetActive(false);
            TalkToSecurity2.SetActive(false);
            TalkToSecurity3.SetActive(false);
        }


        

        if (instance.dialogue.text == "Fine , come in ")
        {
            openPanel.SetActive(true);

        }

        if (instance.dialogue.text == "You too")
        {
            freedom.SetInteger("open", 1);

        }

        if (instance.dialogue.text == "FINE")
        {
            openPanel.SetActive(true);
        }


        if (instance.dialogue.text == "Hmm fine.")
         {
             SecurityLetsYou.SetActive(true);
            SecuritySecond.SetActive(false);
            NotSigned.SetActive(false);
            SecurityNegative.SetActive(false);
        }


        if (instance.dialogue.text == "Sorry, it's just that:")
        {
            option1.SetActive(true);
            option2.SetActive(true);
        }
        else
        {
            option1.SetActive(false);
            option2.SetActive(false);
        }

        if (instance.dialogue.text == "let's see:")
        {
            option1Projector.SetActive(true);
            option2Projector.SetActive(true);
        }
        else
        {
            option1Projector.SetActive(false);
            option2Projector.SetActive(false);
        }

        if (instance.dialogue.text == "Well...")
        {
            TalkToBoss1.SetActive(true);
            TalkToBoss2.SetActive(true);
            TalkToBoss3.SetActive(true);

        }
        else
        {
            TalkToBoss1.SetActive(false);
            TalkToBoss2.SetActive(false);
            TalkToBoss3.SetActive(false);
        }


        if (instance.dialogue.text == "GET BACK TO WORK" || instance.dialogue.text == "I thought so, you're not leaving untill the presentation's finished!")
        {
            bossAnim.SetInteger("BossDoesStuff", 0);

        }

       /* if (instance.dialogue.text == "I thought so, you're not leaving untill the presentation's finished!")
        {
            bossAnim.SetInteger("BossDoesStuff", 0);
        }*/
    }

    public static void StartConversation(Conversation convo)
    {
        instance.anim.SetBool("IsOpen",true);
        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";

        instance.ReadNext();

       
    }

    public void ReadNext()
    {
        if (currentIndex > currentConvo.GetLength())
        {
            instance.anim.SetBool("IsOpen", false);

            return;
        }
        speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();

        //Option1.gameObject.SetActive(false);

        if (typing == null)
        {
            typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));

        }
        else
        {
            instance.StopCoroutine(typing);
            typing = null;
            typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
        }

        speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite();


 


        currentIndex++;

        if (currentIndex> currentConvo.GetLength())
        {
            navButtonText.text = "X";
        }
    }

    private IEnumerator TypeText(string text)
    {
        dialogue.text = "";
        bool complete = false;
        int index = 0;

        while(!complete)
        {
            dialogue.text += text[index];
            index++;
            yield return new WaitForSeconds(0.02f);

            if (index == text.Length)
                complete = true;
        }
        typing = null;
    }

    public static void CloseDialogue()
    {
        instance.anim.SetBool("IsOpen", false);
        Debug.Log("Closed");

    }

}