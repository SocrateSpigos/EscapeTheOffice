using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

public class SuspiciousMeter : MonoBehaviour
{
    //Max suspicious meter cap
    public int suspiciousMeterCapacity = 100;
    //Current suspicious meter starting with 0
    public static int currentSuspiciousMeter;

    //Sprite with only the suspicious meter
    public Sprite suspiciousMeterSprite;
    //Sprite pointer
    public Sprite pointerSprite;

    //Text counting current suspicious Meter 
    public Text suspiciousMeterText;

    //Animator for the pointer
    public Animator pointerAnimator;

    bool firstPhaseToSecondPhase = true ;
    bool secondPhaseToFirstPhase = false;
    bool secondPhaseToThirdPhase = true;
    bool thirdPhaseToSecondPhase = false;
    bool thirdPhaseToFourthPhase = true;
    bool fourthPhaseToThirdPhase = false;
    bool fourthPhaseToFifthPhase = true;
    bool fifthPhaseToFourthPhase = false;
    bool fifthPhaseToSixthPhase = true;
    bool sixthPhasetoFifthPhase = false;

    bool potato = false;
    
    private void Start()
    {
        pointerAnimator = GetComponent<Animator>();
         currentSuspiciousMeter = 0;
}

   

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            currentSuspiciousMeter += 10;
        }
   
        if (Input.GetKeyDown(KeyCode.K))
        {
            currentSuspiciousMeter -= 10;
        }
        SuspiciousMeterRange();
        suspiciousMeterText.text = "Suspicion : " + currentSuspiciousMeter;
    }

    public void SuspiciousMeterRange()
    {
        if(currentSuspiciousMeter < 10 )
        {
            //Debug.Log("Meter is 0-10");
            if (secondPhaseToFirstPhase && !firstPhaseToSecondPhase)
            {
                secondPhaseToFirstPhase = false;
                firstPhaseToSecondPhase = true;             
                pointerAnimator.SetInteger("Condition", 21);
            }
        }
        else if(currentSuspiciousMeter >= 10 && currentSuspiciousMeter < 20)
        {
            
            Debug.Log("Meter is 10-20");
            
            if (firstPhaseToSecondPhase && !secondPhaseToFirstPhase )
            {
                secondPhaseToFirstPhase = true;
                firstPhaseToSecondPhase = false;                
                pointerAnimator.SetInteger("Condition", 12);
            }
            if (thirdPhaseToSecondPhase && !secondPhaseToThirdPhase)
            {
                Debug.Log("Third Phase To Second Phase");
                secondPhaseToThirdPhase = true;
                thirdPhaseToSecondPhase = false;
                pointerAnimator.SetInteger("Condition", 32);
            }
        }
        else if(currentSuspiciousMeter >=20 && currentSuspiciousMeter < 30)
        {         
            Debug.Log("Meter is 20-30");

            if (secondPhaseToThirdPhase && !thirdPhaseToSecondPhase)
            {
                secondPhaseToThirdPhase = false;
                thirdPhaseToSecondPhase = true;
                pointerAnimator.SetInteger("Condition", 23);
            }
            if (fourthPhaseToThirdPhase && !thirdPhaseToFourthPhase)
            {
                fourthPhaseToThirdPhase = false;
                thirdPhaseToFourthPhase = true;
                pointerAnimator.SetInteger("Condition", 43);
            }
        }
        else if (currentSuspiciousMeter >= 30 && currentSuspiciousMeter < 40)
        {
            if (thirdPhaseToFourthPhase && !fourthPhaseToThirdPhase)
            {
                thirdPhaseToFourthPhase = false;
                fourthPhaseToThirdPhase = true;
                pointerAnimator.SetInteger("Condition", 34);
            }
            if (fifthPhaseToFourthPhase && !fourthPhaseToFifthPhase)
            {
                fifthPhaseToFourthPhase = false;
                fourthPhaseToFifthPhase = true;
                pointerAnimator.SetInteger("Condition", 54);
            }
            Debug.Log("Meter is 30-40");
        }
        else if (currentSuspiciousMeter >= 40 && currentSuspiciousMeter < 50)
        {
            if (fourthPhaseToFifthPhase && !fifthPhaseToFourthPhase)
            {
                fourthPhaseToFifthPhase = false;
                fifthPhaseToFourthPhase = true;
                pointerAnimator.SetInteger("Condition", 45);
            }
            if (sixthPhasetoFifthPhase && !fifthPhaseToSixthPhase)
            {
                sixthPhasetoFifthPhase = false;
                fifthPhaseToSixthPhase = true;
                pointerAnimator.SetInteger("Condition", 65);
            }

                Debug.Log("Meter is 40-50");
           
        }
        else if (currentSuspiciousMeter >= 50 && currentSuspiciousMeter < 60)
        {
            if (fifthPhaseToSixthPhase && !sixthPhasetoFifthPhase)
            {
                fifthPhaseToSixthPhase = false;
                sixthPhasetoFifthPhase = true;
                pointerAnimator.SetInteger("Condition", 56);
            }
            Debug.Log("Meter is 50-60");
            
        }
        if (currentSuspiciousMeter > suspiciousMeterCapacity)
        {
            Debug.Log("Game Over");
        }
    }
}
