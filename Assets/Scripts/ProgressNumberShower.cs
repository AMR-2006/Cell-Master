using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressNumberShower : MonoBehaviour
{
    public string textname;
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(textname == "Health")
            text.text = GameVars.Health.ToString();
        if(textname == "Saturation")
            text.text = GameVars.Hunger.ToString();
        if(textname == "POOP")
            text.text = GameVars.POOP.ToString();
        if(textname == "Coin")
            text.text = GameVars.Coin.ToString();
        if(textname == "MoreFood")
            text.text = "More Food " + GameVars.MoreFoodCost.ToString() + "$";
        if (textname == "MaxHealth_Upgrade")
            text.text = "Max Health" + "\n" + GameVars.MaxHealth_UpgradeCost.ToString() + "$";
        if (textname == "Heal")
            text.text = "Heal " + GameVars.MaxHealth.ToString() + "$";
        if (textname == "Damage_Upgrade")
            text.text = "Damage" + "\n" + GameVars.Damage_Upgrade_Cost.ToString() + "$";
        if (textname == "SpeedUP")
            text.text = GameVars.whiteCellSpeed.ToString();
        if (textname == "Targets")
            text.text = GameVars.numberOfTargets.ToString();
        if (textname == "Overall")
            text.text = GameVars.overallPower.ToString();
        if (textname == "WhiteCellCost")
            text.text = "White Cell " + GameVars.whiteCellCost.ToString() + "$";


    }
}
