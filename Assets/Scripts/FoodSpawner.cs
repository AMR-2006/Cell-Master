using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] FoodSelection;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnFood",GameVars.FoodSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnFood() 
    {
        if (!GameVars.Pause_For_Change_Stage)
        {
            GameVars.Food = FoodSelection[Random.Range(0,FoodSelection.Length)];
            Vector3 SpawnPosition = new Vector3(Random.Range(-7f,7f),5.5f,0f);
            Instantiate(GameVars.Food,SpawnPosition,Quaternion.identity);
            Invoke("SpawnFood",GameVars.FoodSpawnTime);
        }
    }
    
    
    
}
