using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;


public class FoodSpawnArea : MonoBehaviour
{
    public Vector3 size;

    public GameObject food;


    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(255, 0, 0);
        Gizmos.DrawWireCube(this.transform.position, size);
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnfood", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void spawnfood()
    {

        Vector3 spawnPoint =
            new Vector3(Random.Range(this.transform.position.x - size.x/2f, this.transform.position.x + size.x/2f),
                Random.Range(this.transform.position.y - size.y/2f, this.transform.position.y + size.y/2f));
        Instantiate(food, spawnPoint, quaternion.identity);
        Invoke("spawnfood", 3f);

    }
    
}
