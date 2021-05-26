using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PaperPickUp : MonoBehaviour
{
    public Inventory inventory;
    public GameObject OpenPanelPaper = null;
    private bool _isInsideTriggerPaper = false;
    public Collider ThePaper;
    public GameObject BossItsUrgent;


    public GameObject SecuritySecond;
    public GameObject NotSigned;
    public GameObject SecurityNegative;


    public void Awake()
    {
        BossItsUrgent.SetActive(false);
    }

    void Update()
    {
        if (IsPaperOpenPanelActive && _isInsideTriggerPaper)   //paper
        {
            if (Input.GetKeyDown(KeyCode.E) && (ThePaper.CompareTag("Item1")))
            {
                OpenPanelPaper.SetActive(false);
                PaperPickingUp();
            }
        }

    }
    private void OnTriggerEnter(Collider ThePaper)
    {
        if (ThePaper.tag == ("Item1"))   //paper
        {
            _isInsideTriggerPaper = true;
            OpenPanelPaper.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
               

                PaperPickingUp();

            }
        }
    }
    public void OnTriggerExit(Collider ThePaper)
    {
        OpenPanelPaper.SetActive(false);
    }

    private bool IsPaperOpenPanelActive  //paper
    {
        get
        {
            return OpenPanelPaper.activeInHierarchy;
        }
    }
    public void PaperPickingUp()  //paper
    {
        BossItsUrgent.SetActive(true);
        SecurityNegative.SetActive(false);
        SecuritySecond.SetActive(false);
        NotSigned.SetActive(true);

        OpenPanelPaper.SetActive(false);
        _isInsideTriggerPaper = false;
        GameObject itemPickedUp = ThePaper.gameObject;
        Item item = itemPickedUp.GetComponent<Item>();
        inventory.AddItem(itemPickedUp, item.id, item.type, item.description, item.icon);
        Debug.Log("Paper");
    }

}