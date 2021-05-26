using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delay : MonoBehaviour
{
    void Start()
    {
    

     IEnumerator Wait()
     {
        Debug.Log("WAITING");
        yield return new WaitForSeconds(5f);

     }
    }
}
