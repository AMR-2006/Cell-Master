 using System.Collections;
 using System.Collections.Generic;
 using EPOOutline;
 using UnityEngine;
 using UnityEngine.SceneManagement;

 public class EnemyAI : MonoBehaviour
{
    [SerializeField] [Range(1,5)] private int Enemytype;
    [SerializeField] [Range(0f, 10f)] private float maxThinkTime;

    [Header("Fill if it is a type 3 virus ")] 
    [SerializeField] [Range(1, 10)] private int waitForRedTime;

    [SerializeField] [Range(1,10)]private int actionTime;
    
    private Vector2 randomeLocation;
    private NavMeshAgent2D agent;

    private int waittime = 0;
    private int redTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        waittime = waitForRedTime;
        redTime = actionTime;
        agent = this.GetComponent<NavMeshAgent2D>();
        if (Enemytype == 1)
        {
            setDistenationtype1();
        }

        if (Enemytype == 2)
        {
            setDistenationtype2();
        }

        if (Enemytype == 3)
        {
            setDistenationtype3();
            Invoke("Action_REDzone", 1f);
        }
        if (Enemytype == 4)
        {
            setDistenationtype4();
        }
        if (Enemytype == 5)
        {
            setDistenationtype5();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void setDistenationtype1()
    {
        randomeLocation = new Vector2(Random.Range(-8f, 8f),Random.Range(-4f, 4f));
        agent.SetDestination(randomeLocation);
        Invoke("setDistenationtype1",Random.Range(0f,maxThinkTime));
    }

    private void setDistenationtype2()
    {
        GameObject target = null;
        if (GameObject.FindWithTag("Food"))
        {
            target = GameObject.FindWithTag("Food");
            agent.SetDestination(target.transform.position);
        }
        Invoke("setDistenationtype2",maxThinkTime);
    }
    
    private void setDistenationtype3()
    {
        Debug.Log("Invoked");
        //agent.SetDestination(Cell.transform.position);
        randomeLocation = new Vector2(Random.Range(-9f, 9f),Random.Range(-4f, 4f));
        agent.SetDestination(randomeLocation);
        Invoke("setDistenationtype3",Random.Range(0,maxThinkTime));
    }
    private void setDistenationtype4()
    {
        GameObject target = null;
        if (GameObject.FindWithTag("Food"))
        {
            target = GameObject.FindWithTag("Food");
            agent.SetDestination(target.transform.position);
        }
        Invoke("setDistenationtype4",maxThinkTime);
    }
    private void setDistenationtype5()
    {
        GameObject target = null;
        if (GameObject.FindWithTag("Food"))
        {
            target = GameObject.FindWithTag("Food");
            agent.SetDestination(target.transform.position);
        }
        Invoke("setDistenationtype5",maxThinkTime);
    }
    
    private void Action_REDzone()
    {
        if (waittime > 0 && redTime == 0)
        {
            //Debug.Log("   WaitTime : " + waittime);
            waittime--;
        }
        if (waittime == 0 && redTime == 0)
        {
            //Debug.Log("WaitTimeFinished");
            redTime = actionTime;
            waittime = waitForRedTime;
        }

        if (redTime > 0)
        {
            //Debug.Log("   RedTime : " + redTime);
            this.gameObject.GetComponent<Outlinable>().enabled = true;
            this.GetComponent<EnemyHealth>().haveTimeToClick = true;
            redTime--;
        }
        else
        {
            //Debug.Log("RedTimeFinished");
            this.gameObject.GetComponent<Outlinable>().enabled = false;
            this.GetComponent<EnemyHealth>().haveTimeToClick = false;
        }

        Invoke("Action_REDzone", 1f);
    }
}
