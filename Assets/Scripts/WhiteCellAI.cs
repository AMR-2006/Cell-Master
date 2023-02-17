using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WhiteCellAI : MonoBehaviour
{
    private NavMeshAgent2D agent;
    public int number_of_targets;

    private int targetleft;
    private AudioSource source;
    private AudioSource Inssource;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if(source == null)
            {
                source = collision.gameObject.GetComponent<EnemyHealth>().source;
            }
            collision.gameObject.GetComponent<EnemyHealth>().playaudio();
            Destroy(collision.gameObject);
            GameVars.EnemyHittingPlayer--;
            GameVars.Coin += 10;
            targetleft--;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent2D>();
        targetleft = number_of_targets;
    }

    // Update is called once per frame
    void Update()
    {
        if(targetleft > 0)
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
        if(targetleft == 0)
        {
            Destroy(this.gameObject);
            playaudio();
        }
    }

    private void playaudio()
    {
        Inssource = Instantiate(source, new Vector3(0, 0, -1f), Quaternion.identity);
        Inssource.Play();
    }
}
