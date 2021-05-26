using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Option", menuName = "Dialogue/New Option")]


public class DialogueButtons : ScriptableObject
{

    [SerializeField] public Button option1;
    [SerializeField] private Button option2;

   

    public Button GetOption1()
    {
        return option1;
    }

    public Button GetOption2()
    {
        return option2;
    }


}
