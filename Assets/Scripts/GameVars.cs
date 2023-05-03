using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameVars
{
    public static float shieldTime = 10f;
    
    public static int Damage_Upgrade_State = 0;
    public static int Damage_Per_Click = 10;
    public static int Damage_Upgrade_Cost = 100;
    public static int MaxHealth = 100;
    public static int MaxHealth_UpgradeCost = 200;
    public static float HealthWaitTime = 2f;
    public static int DamageValue = 2;
    public static bool Pause_For_Change_Stage = false;
    public static int Health = 100;
    public static int Hunger = 100;
    public static int POOP = 0;
    public static int Coin = 1000000;
    public static int MoreFood_Upgrade_State = 0;
    public static int MoreFoodCost = 100;
    public static GameObject Food;
    public static float FoodSpawnTime = 12f;
    public static float EnemySpawnTime = 10f;
    public static float EnemyMainHealth = 100f;
    public static bool isShieldEnable = false;
    
    public static int EnemyHittingPlayer = 0;


    public static float whiteCellSpeed = 1;
    public static int numberOfTargets = 2;
    public static float overallPower = 0;
    public static int whiteCellCost = 50;
    public static int WhiteCellsCount = 0;
    public static int WhiteCellSpeedCost = 20;
    public static int WhiteCellTargetsCost = 20;

    public static string VirusAName;

}
