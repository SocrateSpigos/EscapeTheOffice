using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TechnicianScript : MonoBehaviour
{
    public Collider pc;
    //public Collider tech;

    public GameObject secondDialogueTrigger;
    public GameObject ThirdDialogueTrigger;


    public Animator techAnim;

    public GameObject[] techWaypoints;
    public GameObject[] techWaypoints2;
    public GameObject[] comeBackWaypoints;
    public GameObject[] comeBackWaypoints2;

    public int techNum = 0;
    public int techNum1 = 0;


    public float techMinimumDistance;
    public float techSpeed;

    public bool techRandom = false;
    public bool techGo = false;
    public bool techGo1 = false;
    public bool doneWithTech = false;

    public Animator technicianAnim;
    public Animator vendingAnim;

    public GameObject printer;
    public GameObject maybeLater;

    public Button btn;
    public GameObject techButton;
    public bool buttonPressed = false;

    public Button comeBackBtn;
    public GameObject techComeBack;
    public bool comeBackButtonPressed = false;

    public Button comeBackBtn2;
    public GameObject techComeBack2;
    public bool comeBackButtonPressed2 = false;

    public Button btn2;
    public GameObject techButton2;
    public bool buttonPressed2 = false;

   
    public bool isWalking= true;
    public bool isWalking1= true;

    public GameObject technicianReaction;

    // Start is called before the first frame update
    void Start()
    {
        ThirdDialogueTrigger.SetActive(false);
        techAnim = GetComponent<Animator>();
        techGo = false;

        Button btn = techButton.GetComponent<Button>();
        btn.onClick.AddListener(ButtonPressed);
      
        Button btn2 = techButton2.GetComponent<Button>();
        btn2.onClick.AddListener(ButtonPressed2);
         

        Button comeBackBtn = techComeBack.GetComponent<Button>();
        comeBackBtn.onClick.AddListener(ComeBackButtonPressed);

        Button comeBackBtn2 = techComeBack2.GetComponent<Button>();
        comeBackBtn2.onClick.AddListener(ComeBackButtonPressed2);

    }

    public void ButtonPressed()
    {
        Destroy(secondDialogueTrigger);
        // Debug.Log("Destroyed");
        StartCoroutine(Wait());
    }

    public void ComeBackButtonPressed()
    {
        SuspiciousMeter.currentSuspiciousMeter += 10;

        printer.SetActive(true);
        maybeLater.SetActive(false);

        Destroy(secondDialogueTrigger);
        Debug.Log("ComeBack");
        StartCoroutine(ComeBackWait());
    }

    public void ComeBackButtonPressed2()
    {
        SuspiciousMeter.currentSuspiciousMeter += 10;

        printer.SetActive(true);
        maybeLater.SetActive(false);

        Destroy(secondDialogueTrigger);
        // Debug.Log("Destroyed");
        StartCoroutine(ComeBackWait2());
    }

    public void ButtonPressed2()
    {
        Destroy(secondDialogueTrigger);
        // Debug.Log("Destroyed");
        StartCoroutine(Wait2());
    }
    

  //  private void OnTriggerEnter(Collider pc)
  //  {
   //     if (pc.tag == "Technician")
   //     {
     //       Debug.Log("WERE IN");
            // doorAndDialogueScript._animator.SetBool("Open", true);
            //doorAndDialogueScript._animator.SetBool("Close", false);
     //   }
   // }

    // Update is called once per frame
    void Update()
    {
        TechTest();

        if (buttonPressed)
        {
            //Debug.Log("update");

            float distance = Vector3.Distance(gameObject.transform.position, techWaypoints[techNum].transform.position);

            if (techGo)
            {
                StartCoroutine(Wait());

                //techAnim.SetInteger("TechnicianReacts", 1);

                if (distance > techMinimumDistance)
                {
                    Move();
                }

                else
                {
                    if (!techRandom)
                    {

                        //Idle();
                        if (techNum + 1 == techWaypoints.Length)
                        {
                            techGo = false;
                            techAnim.SetInteger("TechnicianReacts", 0);
                            isWalking = false;
                        }
                        else
                        {
                            techNum++;
                        }
                    }
                    else
                    {
                        techNum = Random.Range(0, techWaypoints.Length);
                    }
                }
            }
        }

        if (buttonPressed2)
        {
            //Debug.Log("update");

            float distance = Vector3.Distance(gameObject.transform.position, techWaypoints2[techNum].transform.position);

            if (techGo)
            {
                StartCoroutine(Wait2());

               // techAnim.SetInteger("TechnicianReacts", 1);

                if (distance > techMinimumDistance)
                {
                    Move2();
                }

                else
                {
                    if (!techRandom)
                    {

                        //Idle();
                        if (techNum + 1 == techWaypoints2.Length)
                        {
                            techGo = false;
                            techAnim.SetInteger("TechnicianReacts", 0);
                            vendingAnim.SetInteger("IsGettingFixed", 1);

                            isWalking = false;


                        }
                        else
                        {
                            techNum++;
                        }
                    }
                    else
                    {
                        techNum = Random.Range(0, techWaypoints2.Length);
                    }
                }
            }
        }


        TechTest2();

        if (comeBackButtonPressed)
        {



            float distance = Vector3.Distance(gameObject.transform.position, comeBackWaypoints[techNum1].transform.position);

            if (techGo1)
            {
                Debug.Log("techGo1");


                StartCoroutine(ComeBackWait());

                //techAnim.SetInteger("TechnicianReacts", 1);

                if (distance > techMinimumDistance)
                {
                    Move3();

                }

                else
                {
                    if (!techRandom)
                    {

                        //Idle();
                        if (techNum1 + 1 == comeBackWaypoints.Length)
                        {

                            techGo = false;
                            techAnim.SetInteger("TechnicianReacts", 2);
                            isWalking1 = false;
                            technicianReaction.SetActive(true); 
                        }
                        else
                        {
                            techNum1++;
                        }
                    }
                    else
                    {
                        techNum1 = Random.Range(0, comeBackWaypoints.Length);
                    }
                }
            }
        }

        if (comeBackButtonPressed2)
        {


            float distance = Vector3.Distance(gameObject.transform.position, comeBackWaypoints2[techNum1].transform.position);

            if (techGo1)
            {


                StartCoroutine(ComeBackWait2());

                 //techAnim.SetInteger("TechnicianReacts", 1);

                if (distance > techMinimumDistance)
                {
                    Debug.Log("distance");

                    Move4();
                }

                else
                {
                    if (!techRandom)
                    {

                        //Idle();
                        if (techNum1 + 1 == comeBackWaypoints2.Length)
                        {
                            Debug.Log("yep");

                            techGo = false;
                            techAnim.SetInteger("TechnicianReacts", 2);
                            vendingAnim.SetInteger("IsGettingFixed", 1);
                            technicianReaction.SetActive(true);

                            isWalking1 = false;

                        }
                        else
                        {
                            techNum1++;
                        }
                    }
                    else
                    {
                        techNum1 = Random.Range(0, comeBackWaypoints2.Length);
                    }
                }
            }
        }
    }
    public void Move()
    {
        gameObject.transform.LookAt(techWaypoints[techNum].transform.position);
        gameObject.transform.position += gameObject.transform.forward * techSpeed * Time.deltaTime;
        //Debug.Log("move");

    }

    public void Move2()
    {
        gameObject.transform.LookAt(techWaypoints2[techNum].transform.position);
        gameObject.transform.position += gameObject.transform.forward * techSpeed * Time.deltaTime;
       // Debug.Log("move");

    }

    public void Move3()
    {
        Debug.Log("MoveComeBack");

        gameObject.transform.LookAt(comeBackWaypoints[techNum1].transform.position);
        gameObject.transform.position += gameObject.transform.forward * techSpeed * Time.deltaTime;
        // Debug.Log("move");

    }

    public void Move4()
    {
        gameObject.transform.LookAt(comeBackWaypoints2[techNum1].transform.position);
        gameObject.transform.position += gameObject.transform.forward * techSpeed * Time.deltaTime;
        // Debug.Log("move");

    }


    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        buttonPressed = true;

        //Debug.Log("ButtonPressed");
        TechTest();
        //Debug.Log("WaitIsOver");

    }

    public IEnumerator Wait2()
    {
        yield return new WaitForSeconds(1f);
        buttonPressed2 = true;

        //Debug.Log("ButtonPressed");
        TechTest();
        //Debug.Log("WaitIsOver");

    }

    public IEnumerator ComeBackWait()
    {
        yield return new WaitForSeconds(1f);
        comeBackButtonPressed = true;
        buttonPressed = false;
        buttonPressed2 = false;
        techGo = false;
        //isWalking = true;

        Debug.Log("ButtonPressed");
        TechTest2();
        //Debug.Log("WaitIsOver");

    }

    public IEnumerator ComeBackWait2()
    {
        yield return new WaitForSeconds(1f);
        comeBackButtonPressed2 = true;
        buttonPressed = false;
        buttonPressed2 = false;
        techGo = false;
        //isWalking = true;


        //Debug.Log("ButtonPressed");
        TechTest2();
        //Debug.Log("WaitIsOver");

    }

    public void TechTest()
    {
        if (buttonPressed || buttonPressed2)
        {
            //Debug.Log("TechTest");


            ThirdDialogueTrigger.SetActive(true);

            if (isWalking)
            {

                techAnim.SetInteger("TechnicianReacts", 1);
            }
            techGo = true;


        }
    }

        public void TechTest2()
        {
            if (comeBackButtonPressed || comeBackButtonPressed2)
            {

           
              //Debug.Log("TechTestlolz");

                if (isWalking1)
                {

                 techAnim.SetInteger("TechnicianReacts", 1);

                }

              techGo1 = true;
            doneWithTech = true;

            }

        }

}
