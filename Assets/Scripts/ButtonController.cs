using System.Collections;
using System.Collections.Generic;
using DamageNumbersPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ButtonController : MonoBehaviour
{
    public GameObject Shield;
    public void Eat()
    {
        if(GameVars.Hunger < 100)
        {
            GameVars.Hunger += 1;
        }
    }

    public void Garbage()
    {
        if(GameVars.POOP > 0)
        {
            GameVars.POOP -= 1;
            GameVars.Coin += 1;
        }
    }

    public void SetHungerToMax()
    {
        if(GameVars.Coin >= 200)
        {
            GameVars.Coin -= 200;
            GameVars.Hunger = 100;
        }
    }

    public void SetHealthToMax()
    {
        if(GameVars.Coin >= GameVars.MaxHealth)
        {
            GameVars.Coin -= GameVars.MaxHealth;
            GameVars.Health = GameVars.MaxHealth;
        }
    }

    public void MoreFood()
    {
        if(GameVars.Coin >= GameVars.MoreFoodCost && GameVars.MoreFood_Upgrade_State < 3)
        {
            GameVars.Coin -= GameVars.MoreFoodCost;
            GameVars.FoodSpawnTime = GameVars.FoodSpawnTime/2;
            GameVars.MoreFoodCost += GameVars.MoreFoodCost;
            if (GameVars.EnemySpawnTime > 0 && GameVars.EnemySpawnTime - 2 >= 0)
            {
                GameVars.EnemySpawnTime -= 2;
            }
            GameVars.MoreFood_Upgrade_State += 1;
        }
    }

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void ChangeStageTo2()
    {
        GameVars.Pause_For_Change_Stage = true;
    }

    public void Upgrade_MaxHealth()
    {
        GameVars.MaxHealth += 100;
        if (GameVars.Coin >= GameVars.MaxHealth_UpgradeCost)
        {
            GameVars.Coin -= GameVars.MaxHealth_UpgradeCost;
            GameVars.MaxHealth_UpgradeCost += 100;
        }
    }

    public void Upgrade_Damage()
    {
        if (GameVars.Coin >= GameVars.Damage_Upgrade_Cost && GameVars.Damage_Upgrade_State < 3)
        {
            GameVars.Coin -= GameVars.Damage_Upgrade_Cost;
            GameVars.Damage_Per_Click += 10;
            GameVars.Damage_Upgrade_Cost += 50;
            GameVars.Damage_Upgrade_State += 1;
        }
    }

    public void Upgrade_Sheild()
    {
        if (!GameVars.isShieldEnable)
        {
            GameVars.Coin -= 100;
            GameVars.isShieldEnable = true;
            Debug.Log("Shield");
            Invoke("setShieldActivation",GameVars.shieldTime);
            
        }
    }

    public void Upgrage_WhiteCell_Speed()
    {
        if (GameVars.Coin >= 50)
        {
            GameVars.whiteCellSpeed += 1;
            GameVars.whiteCellCost += 50;
            GameVars.Coin -= 50;
        }
    }
    
    public void Upgrage_WhiteCell_Targets()
    {
        if (GameVars.Coin >= 50)
        {
            GameVars.numberOfTargets += 1;
            GameVars.whiteCellCost += 50;
            GameVars.Coin -= 50;
        }
    }
    
    private void setShieldActivation()
    {
        Shield.SetActive(false);
        GameVars.isShieldEnable = false;
    }
}
