using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnWhiteCell : MonoBehaviour
{
    public GameObject SelectedObject;
    public GameObject WhiteCell;
    public GameObject Text;
    private bool isSpawn;
    private bool isSelected;
    private GameObject spawnobject;


    void Start()
    {
        spawnobject = Instantiate(SelectedObject,Input.mousePosition,quaternion.identity);
        spawnobject.SetActive(false);
    }

    void Update()
    {
        Vector3 mousePosition = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
        if (isSelected && !isSpawn)
        {
            Text.SetActive(true);
            spawnobject.SetActive(true);
            spawnobject.transform.position = mousePosition;
        }

        if (Input.GetKeyDown("space") && !isSpawn && isSelected)
        {
            Text.SetActive(false);
            GameVars.Coin -= 200;
            isSpawn = true;
            isSelected = false;
            Instantiate(WhiteCell, mousePosition, Quaternion.identity);
            spawnobject.SetActive(false);
        }
    }

    public void Select()
    {
        isSelected= true;
        isSpawn= false;
        spawnobject.SetActive(true);
    }
}
