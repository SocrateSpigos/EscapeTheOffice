using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ToggleRenderer : MonoBehaviour
{
    //public TextMeshProUGUI trydatshit = "?" ;

    public void toggleVisibility()
    {
        //TheDialogueManager theDialogueManager = new TheDialogueManager();

        //if (theDialogueManager.dialogue = trydatshit)
        //{
            Image rend = gameObject.GetComponent<Image>();

            if (rend.enabled)
                rend.enabled = false;
            else rend.enabled = true;
        //}
    }
}
