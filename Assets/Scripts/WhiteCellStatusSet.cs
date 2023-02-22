using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCellStatusSet : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.GetComponent<NavMeshAgent2D>().speed = GameVars.whiteCellSpeed;
        this.GetComponent<WhiteCellAI>().number_of_targets = GameVars.numberOfTargets;
    }
}
