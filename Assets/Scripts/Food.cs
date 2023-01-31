using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float waittime = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetHungry();
    }

    private void GetHungry()
    {
        if(GameVars.Hunger!=0)
        {
            GameVars.Hunger -= 1;
        }
        Invoke("GetHungry", waittime);
    }
}
