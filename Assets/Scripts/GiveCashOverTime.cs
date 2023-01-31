using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveCashOverTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GiveCash", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void GiveCash()
    {
        if(GameVars.Health >= 80)
        {
            GameVars.Coin += 2;
        }
        Invoke("GiveCash", 3f);
    }
}
