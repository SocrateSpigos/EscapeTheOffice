using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    //private PlayerController playerControllerScript;
    //private Inventory inventoryScript;
    //private Item itemScript;
    private DoorAndDialogueScript doorAndDialogueScript;

    private Animator bossAnimator;
    // Start is called before the first frame update
    void Start()
    {
        bossAnimator = GetComponent<Animator>();
        //playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Door")
        {
           // doorAndDialogueScript._animator.SetBool("Open", true);
            //doorAndDialogueScript._animator.SetBool("Close", false);
        }
    }
}
