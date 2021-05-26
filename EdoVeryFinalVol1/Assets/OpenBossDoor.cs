using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBossDoor : MonoBehaviour
{
    public Animator _animator;

    void OnTriggerEnter()
    {
        _animator.SetBool("Open", true);
        _animator.SetBool("Close", false);



    }

}
