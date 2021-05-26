using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    public GameObject OpenPanelSandwich = null;
    //public GameObject OpenPanelPaper = null;
    public GameObject cube;


    private bool _isInsideTriggerSandwich = false;
   // private bool _isInsideTriggerPaper = false;

    bool inventoryEnabled;
    public int i = 0;
    public GameObject inventory;
    public GameObject slotHolder;
    public Collider sandwich;
    //public Collider paper;

    private int allSlots;
    private int enabledSlots;

    private GameObject[] slot;

    void Start()
    {
        allSlots = 8;
        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

            if(slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnabled = !inventoryEnabled;
        }
        if(inventoryEnabled == true)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }


        if (IsSandwichOpenPanelActive && _isInsideTriggerSandwich)
        {
            if (Input.GetKeyDown(KeyCode.E) && (sandwich.CompareTag("Item")))
            {
                cube.SetActive(false);
                OpenPanelSandwich.SetActive(false);
                SandwichPickUp();
            }
        }

      /*  if (IsPaperOpenPanelActive && _isInsideTriggerPaper)
        {
            if (Input.GetKeyDown(KeyCode.E) && (paper.CompareTag("Item")))
            {
                OpenPanelPaper.SetActive(false);
                PaperPickUp();
            }
        }

        */

       /* if (Input.GetKeyDown(KeyCode.E) && (sandwich.tag == "Item"))
        {
            SandwichPickUp();
        }*/
    }



    void OnTriggerEnter(Collider sandwich)
    {
        if (sandwich.tag == ("Item"))
        {
            _isInsideTriggerSandwich = true;
            OpenPanelSandwich.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SandwichPickUp();
            }                     
        }

        /*
        if (paper.tag == ("Item"))
        {
            _isInsideTriggerPaper = true;
            OpenPanelPaper.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PaperPickUp();
            }
        }
        */
    }

   

    private bool IsSandwichOpenPanelActive
    {
        get
        {
            return OpenPanelSandwich.activeInHierarchy;
        }
    }

   /* private bool IsPaperOpenPanelActive
    {
        get
        {
            return OpenPanelPaper.activeInHierarchy;
        }
    }
    */

    public void SandwichPickUp()
    {
        OpenPanelSandwich.SetActive(false);
        _isInsideTriggerSandwich = false;
        GameObject itemPickedUp = sandwich.gameObject;
                Item item = itemPickedUp.GetComponent<Item>();
                AddItem(itemPickedUp, item.id, item.type, item.description, item.icon); 
    }

   /* 
      public void PaperPickUp()
    {
        OpenPanelPaper.SetActive(false);
        _isInsideTriggerPaper = false;
        GameObject itemPickedUp = paper.gameObject;
                Item item = itemPickedUp.GetComponent<Item>();
                AddItem(itemPickedUp, item.id, item.type, item.description, item.icon); 
    }
    */

    public void AddItem(GameObject itemObject,int itemID , string itemType , string itemDescription , Sprite itemIcon)
    {
       
            if (i < allSlots)
            {
                if (slot[i].GetComponent<Slot>().empty)
                {
                    itemObject.GetComponent<Item>().pickedUp = true;

                    slot[i].GetComponent<Slot>().item = itemObject;
                    slot[i].GetComponent<Slot>().icon = itemIcon;
                    slot[i].GetComponent<Slot>().type = itemType;
                    slot[i].GetComponent<Slot>().id = itemID;
                    slot[i].GetComponent<Slot>().description = itemDescription;

                    itemObject.transform.parent = slot[i].transform;
                    itemObject.SetActive(false);              
                    slot[i].GetComponent<Slot>().UpdateSlot();
                    slot[i].GetComponent<Slot>().empty = false;
                i++;
                }
                return;
            }        
    }
}
