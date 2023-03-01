using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WhiteCellAI : MonoBehaviour
{
    private NavMeshAgent2D agent;
    private int number_of_targets;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyHealth>().playaudio();
            Destroy(collision.gameObject);
            GameVars.EnemyHittingPlayer--;
            GameVars.Coin += 10;
            number_of_targets--;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent2D>();
        number_of_targets = GameVars.numberOfTargets;
    }

    // Update is called once per frame
    void Update()
    {
        if(number_of_targets > 0)
        {
            if(GameObject.FindWithTag("Enemy"))
            {
                GameObject target = GameObject.FindWithTag("Enemy");
                agent.SetDestination(target.transform.position);
            }
            else
            {
                if (GameObject.FindWithTag("Food"))
                {
                    GameObject target = GameObject.FindWithTag("Food");
                    agent.SetDestination(target.transform.position);
                }
            }
        }
        if(number_of_targets == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
