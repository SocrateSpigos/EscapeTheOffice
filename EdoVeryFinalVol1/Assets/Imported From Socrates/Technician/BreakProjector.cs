/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BreakProjector : MonoBehaviour
{
    public Collider Projector;
    public Camera PpsCam;
    public Camera TpsCam;
    bool ppsCam = true;
    bool tpsCam = true;
    public Button proj;
    public GameObject projButton;
    public bool isInsideProjector = true;
    public Animator projectorAnim;

    void Start()
    {
        Button proj = projButton.GetComponent<Button>();
        proj.onClick.AddListener(ProjectorButtonPressed);
        //PpsCam.enabled = ppsCam;
        // TpsCam.enabled = !ppsCam;
    }
    /* public void OnTriggerEnter()
     {

             ppsCam = !ppsCam;
             PpsCam.enabled = ppsCam;
             TpsCam.enabled = !ppsCam;

     }
    public void ProjectorButtonPressed()
    {
       bool isInsideProjector = true;

        chairAnim = GetComponent<Animator>();

        projectorAnim.SetInteger("breakProjector", 1);
    }

    public void OnTriggerStay()
    {
    if (isInsideProjector == true)
    {
        ppsCam = !ppsCam;
        PpsCam.enabled = ppsCam;
        TpsCam.enabled = !ppsCam;
    }

    }


    public void OnTriggerExit()
    {
        ppsCam = !ppsCam;
        PpsCam.enabled = ppsCam;
        TpsCam.enabled = !ppsCam;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}*/

