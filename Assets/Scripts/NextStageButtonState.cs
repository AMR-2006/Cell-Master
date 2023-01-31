using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class NextStageButtonState : MonoBehaviour
{


    public GameObject NextStage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameVars.Coin >= 600)
        {
            NextStage.gameObject.SetActive(true);
        }

        if (this.gameObject.active && GameVars.Coin < 600)
        {
            NextStage.gameObject.SetActive(false);
        }
    }
}
