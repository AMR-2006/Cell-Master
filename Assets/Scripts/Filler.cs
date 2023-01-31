using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Filler : MonoBehaviour
{

    private Image fillAmountImage;
    public string WhichBar;
    // Start is called before the first frame update
    void Start()
    {
       fillAmountImage = this.GetComponent<Image>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(WhichBar == "Health")
       {
            fillAmountImage.fillAmount = IntToFloat_Health(GameVars.Health);
       }
       if(WhichBar == "Saturation")
       {
            fillAmountImage.fillAmount = IntToFloat(GameVars.Hunger);
       }
       if(WhichBar == "POOP")
       {
            fillAmountImage.fillAmount = IntToFloat(GameVars.POOP);
       }

    } 

     private float IntToFloat(int a)
     {
          float floatnumber = 0;
          float inputtofloat = a;
          floatnumber = inputtofloat/100f;
          return floatnumber;
     }private float IntToFloat_Health(int a)
     {
          float floatnumber = 0;
          float inputtofloat = a;
          floatnumber = inputtofloat/GameVars.MaxHealth;
          return floatnumber;
     }
     
}
