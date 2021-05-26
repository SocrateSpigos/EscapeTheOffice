using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//We want the guy to be in the precise square/trigger when sitting
//γTry one big animator for everything


public class PlayerController : MonoBehaviour
{
    // private bool isInsideChairTrigger = false;

     //public bool canMove = true;

     float speed = 4;
     float rotSpeed = 80;
     float gravity = 8;
     float rot = 0f;

    public Collider col;
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator anim;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        //bool canMove = true;

    }

    void Update()
    {

        Movement();
        Getinput();
        DoorTrigger();
    }

    void DoorTrigger()
    {
        if (Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.W)) //&& GameObject.FindGameObjectWithTag("Door"))
        {
            anim.SetBool("DoorTrigger", true);
            anim.SetInteger("Condition", 2);
            //DoorScript.FindObjectOfType<Animator>();
        }
        if (Input.GetKeyUp(KeyCode.E) && !Input.GetKey(KeyCode.W))
        {
            anim.SetBool("DoorTrigger", false);
            anim.SetInteger("Condition", 0);
        }
    }

    void OnTriggerEnter(Collider col)
    {
       
     }


    void Movement()
    {
        //bool canMove = true; 

        if (controller.isGrounded )
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("running", true);
                anim.SetInteger("Condition1", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
               // Debug.Log("GO");

            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("running", false);
                anim.SetInteger("Condition1", 0);
                moveDir = new Vector3(0, 0, 0);
               // Debug.Log("STAHP");

            }
        }
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

    void Getinput()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Interacting();
            }

           // if (Input.GetKey(KeyCode.Q))
            //{
                //controller.transform.rotation = this.transform.rotation;
                //Debug.Log("should work");
               // Sitting();

                //targetAngles = transform.eulerAngles + 180f * Vector3.up; // what the new angles should be

                //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, smooth * Time.deltaTime);
          //  }
        }
    }

    void Interacting()
    {
        anim.SetInteger("Condition1", 2);
    }

    public void Sitting()
    {

        anim.SetInteger("Condition1", 3);

    }
}

