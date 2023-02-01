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
            new Vector3(Random.Range(this.transform.position.x - size.x, this.transform.position.x + size.x),
                Random.Range(this.transform.position.y - size.y, this.transform.position.y + size.y));
        Instantiate(food, spawnPoint, quaternion.identity);
        Invoke("spawnfood", 3f);

    }
    
}
/*
[CustomEditor(typeof(FoodSpawnArea)), CanEditMultipleObjects] 

public class FoodSpawnAreaEditor : Editor
{
    public Transform center;
    public Vector3 size;
    private void OnSceneGUI()
    {
        var Color = new Color(255, 0, 0);
        
    }
}
*/
