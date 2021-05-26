using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarthasBehaviour : MonoBehaviour
{

    public GameObject[] waypoints;

    public int num = 0;

    public float minimumDistance;
    public float speed;

    public bool random = false;
    public bool go = true;

    Animator marthasAnimator;

    // Start is called before the first frame update
    void Start()
    {
        marthasAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, waypoints[num].transform.position);
       
        if(go)
        {
            if (distance > minimumDistance)
            {
                Move();
            }

            else
            {
                if (!random)
                {
                    
                    //Idle();
                    if (num + 1 == waypoints.Length)
                    {
                        num = 0;
                    }
                    else
                    {
                        num++;
                    }
                }
                else
                {
                    num = Random.Range(0, waypoints.Length);
                }
            }
        } 
    }   
    public void Move()
    {
        gameObject.transform.LookAt(waypoints[num].transform.position);
        gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
    }
    /*
    void Idle()
    {
        gameObject.transform.position = gameObject.transform.position * Time.deltaTime;
    }
    */
}
