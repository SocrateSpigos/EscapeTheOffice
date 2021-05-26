using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]

public class DialogueLine
{ 
   public Speaker speaker;
        [TextArea]
    public string dialogue;
    //public TextMeshProUGUI option1, option2;


    public DialogueButtons answer1;
    
    //public Button Option2;



}
