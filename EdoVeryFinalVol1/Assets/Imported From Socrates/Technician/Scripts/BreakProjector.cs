using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BreakProjector : MonoBehaviour
{
    public Collider Projector;
    public Camera PpsCam;
    public Camera TpsCam;
    public Camera FpsCam;

    public Button proj;
    public GameObject projButton;
    public Animator projectorAnim;

    public Button laptop;
    public GameObject lapButton;
    public Animator lapAnim;
    public bool ButtonIsPressed= false;



    void Start()
    {
        FpsCam.enabled = true;
        TpsCam.enabled = false;
        PpsCam.enabled = false;

        projectorAnim = GetComponent<Animator>();
        lapAnim = GetComponent<Animator>();


        Button laptop = lapButton.GetComponent<Button>();
        laptop.onClick.AddListener(LaptopButtonPressed);

        Button proj = projButton.GetComponent<Button>();
        proj.onClick.AddListener(ProjectorButtonPressed);
        // Debug.Log("Projector Button Pressed");

        


    }
    public void OnTriggerEnter()
    {
             PpsCam.enabled = true; 
             TpsCam.enabled = false; 

}
    public void ProjectorButtonPressed()
    {

        projectorAnim.SetInteger("BreakProjector", 1);
        StartCoroutine(Waiting());

        Destroy(Projector);
        ButtonIsPressed = true;

        Debug.Log("ProjectorBreak");
    }

    public void LaptopButtonPressed()
    {
        lapAnim.SetInteger("DestroyLaptop", 1);
        StartCoroutine(Waiting());

        Destroy(Projector);
        ButtonIsPressed= true;

        Debug.Log("LaptopDestroyed");
    }



    public void OnTriggerExit()
    {
        PpsCam.enabled = false;
        TpsCam.enabled = true;

    }
    // Update is called once per frame
    
    IEnumerator Waiting()
    {
        Debug.Log("WAITING");
        yield return new WaitForSeconds(4f);
        PpsCam.enabled = false;
        TpsCam.enabled = true;
    }
    
}
