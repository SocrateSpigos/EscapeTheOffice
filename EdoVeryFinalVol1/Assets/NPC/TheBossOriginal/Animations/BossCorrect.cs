/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCorrect : MonoBehaviour
{
    public Collider boss;
    public Animator bossAnim;

    public GameObject[] bossWaypoints;

    public int bossNum = 0;

    public float bossMinimumDistance;
    public float bossSpeed;

    public bool bossRandom = false;
    public bool bossGo = true;

    void Start()
    {
        bossAnim = GetComponent<Animator>();
    }


    void BossTest()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            bossAnim.SetInteger("BossDoesStuff", 1);
        }
    }

    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, bossWaypoints[bossNum].transform.position);

        if (bossGo)
        {
            StartCoroutine(Wait());

            bossAnim.SetInteger("BossDoesStuff", 1);

            if (distance > bossMinimumDistance)
            {
                Move();
            }

            else
            {
                if (!bossRandom)
                {

                    //Idle();
                    if (bossNum + 1 == bossWaypoints.Length)
                    {
                        bossNum = 0;
                    }
                    else
                    {
                        bossNum++;
                    }
                }
                else
                {
                    bossNum = Random.Range(0, bossWaypoints.Length);
                }
            }
        }
    }
    public void Move()
    {
        gameObject.transform.LookAt(bossWaypoints[bossNum].transform.position);
        gameObject.transform.position += gameObject.transform.forward * bossSpeed * Time.deltaTime;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        
        Debug.Log("WaitIsOver");
    }
}*/

