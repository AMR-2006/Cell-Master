using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellGangStageMaker : MonoBehaviour
{
    public GameObject OldPlayer;
    public GameObject NewPlayer;
    public void SceneMaker()
    {
        GameVars.Pause_For_Change_Stage = true;
        Instantiate(NewPlayer, new Vector3(0.69f, -0.78f, 0), Quaternion.identity);
        Destroy(OldPlayer);
        GameVars.Coin -= 600;
        GameVars.Health = GameVars.MaxHealth;
        GameVars.Hunger = 100;
        GameVars.POOP = 0;
        GameVars.FoodSpawnTime = 6f;
        GameVars.EnemySpawnTime = 10f;
        GameVars.Pause_For_Change_Stage = false;
    }
}
