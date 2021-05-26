/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Paper : MonoBehaviour
{
    public Inventory inventory;
    public GameObject OpenPanelPaper = null;
    private bool _isInsideTriggerPaper = false;
    public Collider ThePaper;

    
    void Update()
    {
        if (IsPaperOpenPanelActive && _isInsideTriggerPaper)   //paper
        {
            if (Input.GetKeyDown(KeyCode.E) && (ThePaper.CompareTag("Item1")))
            {
                OpenPanelPaper.SetActive(false);
                PaperPickUp();
            }
        }

    }
    private void OnTriggerEnter(Collider Paper)
    {
        if (ThePaper.tag == ("Item1"))   //paper
        {
            _isInsideTriggerPaper = true;
            OpenPanelPaper.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PaperPickUp();
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
    public void PaperPickUp()  //paper
    {
        OpenPanelPaper.SetActive(false);
        _isInsideTriggerPaper = false;
        GameObject itemPickedUp = ThePaper.gameObject;
        Item item = itemPickedUp.GetComponent<Item>();
        inventory.AddItem(itemPickedUp, item.id, item.type, item.description, item.icon);
        Debug.Log("Paper");
    }

}
*/