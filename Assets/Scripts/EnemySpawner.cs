using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] Enemy;
    private Vector3[] EnemySpawnPoint = new Vector3[4]; 

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn",GameVars.EnemySpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        if (!GameVars.Pause_For_Change_Stage)
        {
            EnemySpawnPoint[0] = new Vector3(Random.Range(-3f,-5f),Random.Range(-4f,4f),0f);
            EnemySpawnPoint[1] = new Vector3(Random.Range(3f,5f),Random.Range(-4f,4f),0f);
            EnemySpawnPoint[2] = new Vector3(Random.Range(-5f,5f),Random.Range(3,4f),0f);
            EnemySpawnPoint[3] = new Vector3(Random.Range(-5f,5f),Random.Range(-3f,-4f),0f);
            Instantiate(Enemy[Random.Range(0,Enemy.Length)],EnemySpawnPoint[Random.Range(0,EnemySpawnPoint.Length)],Quaternion.identity);
            //GameVars.EnemyInTheWorldCount += 1;
            //Debug.Log(GameVars.EnemyInTheWorldCount);
            Invoke("Spawn",GameVars.EnemySpawnTime);
        }
    }
}
 