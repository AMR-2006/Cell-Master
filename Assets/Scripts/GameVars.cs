using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameVars
{
    public static int Damage_Upgrade_State = 0;
    public static float Damage_Per_Click = 10;
    public static int Damage_Upgrade_Cost = 100;
    public static int MaxHealth = 100;
    public static int MaxHealth_UpgradeCost = 200;
    public static float HealthWaitTime = 2f;
    public static int DamageValue = 2;
    public static bool Pause_For_Change_Stage = false;
    public static int Health = 100;
    public static int Hunger = 100;
    public static int POOP = 0;
    public static int Coin = 500;
    public static int MoreFood_Upgrade_State = 0;
    public static int MoreFoodCost = 100;
    public static GameObject Food;
    public static float FoodSpawnTime = 6f;
    public static float EnemySpawnTime = 10f;
    public static float EnemyMainHealth = 100f;
    public static int EnemyInTheWorldCount = 0;
    public static bool isShieldEnable = false;



    public static string VirusAName; 
}
