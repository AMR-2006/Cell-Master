 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

 public class EnemyAI : MonoBehaviour
{
    [SerializeField] [Range(1,3)] private int Enemytype;
    [SerializeField] [Range(1f, 10f)] private float maxThinkTime;
    
    private Vector2 randomeLocation;
    private NavMeshAgent2D agent;
    private GameObject Cell;
    
    // Start is called before the first frame update
    void Start()
    {
        Cell = GameObject.FindWithTag("Player");
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
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void setDistenationtype1()
    {
        randomeLocation = new Vector2(Random.Range(-9f, 9f),Random.Range(-4f, 4f));
        agent.SetDestination(randomeLocation);
        Invoke("setDistenationtype1",Random.Range(0f,maxThinkTime));
    }

    private void setDistenationtype2()
    {
        GameObject target = null;
        target = GameObject.FindWithTag("Food");
        if (target != null)
        {
            agent.SetDestination(target.transform.position);
        }
        Invoke("setDistenationtype2",maxThinkTime);
    }
    
    private void setDistenationtype3()
    {
        //agent.SetDestination(Cell.transform.position);
        randomeLocation = new Vector2(Random.Range(-9f, 9f),Random.Range(-4f, 4f));
        agent.SetDestination(randomeLocation);
        Invoke("setDistenationtype1",Random.Range(0f,maxThinkTime));
    }
}
