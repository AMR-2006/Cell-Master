using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : MonoBehaviour
{
    public float waittime = 0;
    // Start is called before the first frame update
    void Start()
    {
        MakingGarbage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MakingGarbage()
    {
        if(GameVars.POOP < 100)
        {
            GameVars.POOP += 1;
        }
        Invoke("MakingGarbage", waittime);
    }
}
