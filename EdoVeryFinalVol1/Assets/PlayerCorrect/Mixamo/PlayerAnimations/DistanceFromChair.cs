using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceFromChair : MonoBehaviour
{
    Animator anim;

    public GameObject character;

    
    void Update()
    {
        if (Vector3.Distance(character.transform.position, this.transform.position) <0.5)
        {
            anim.SetInteger("Condition1", 3);

            character.transform.rotation = this.transform.rotation;
        }
    }
}
