using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Health : MonoBehaviour
{
    private float waittime = GameVars.HealthWaitTime;
    // Start is called before the first frame update
    void Start()
    {
        ManageHealth();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ManageHealth()
    {
        if (!GameVars.Pause_For_Change_Stage)
        {
            GetHungry();
            GiveCash();
            MakingGarbage();
        
            if((GameVars.Hunger == 20 || GameVars.POOP == 60) && GameVars.Health != 0)
            {
                Damage(GameVars.DamageValue);
            }

            if (GameVars.EnemyHittingPlayer > 0 && GameVars.Health != 0 && !GameVars.isShieldEnable)
            {
                Damage(GameVars.EnemyHittingPlayer);
            }
            if(GameVars.Hunger >= 20 && GameVars.Health < GameVars.MaxHealth)
            {
                Heal();
            }
            Invoke("ManageHealth", waittime);
        }
    }
    private void Damage(int Time)
    {
        GameVars.Health -= 1*Time;
    }
    private void Heal()
    {
        GameVars.Health += 1;
    }
    private void GetHungry()
    {
        if(GameVars.Hunger!=0)
        {
            GameVars.Hunger -= 1;
        }
    }
    private void GiveCash()
    {
        if(GameVars.Health >= 80)
        {
            GameVars.Coin += 2;
        }
    }
    private void MakingGarbage()
    {
        if(GameVars.POOP < 100)
        {
            GameVars.POOP += 1;
        }
    }
}
