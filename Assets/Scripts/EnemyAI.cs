 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] [Range(1,3)] private int Enemytype;
    [SerializeField] [Range(1f, 10f)] private float maxThinkTime;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameVars.Health -= 1;
            Debug.Log(GameVars.Health);
        }
    }

    private Vector2 randomeLocation;
    private NavMeshAgent2D agent;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent2D>();
        setDistenation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void setDistenation()
    {
        randomeLocation = new Vector2(Random.Range(-9f, 9f),Random.Range(-4f, 4f));
        Invoke("setDistenation",Random.Range(0f,maxThinkTime));
    }
}
