using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCellStatusSet : MonoBehaviour
{
    private void Update()
    {
        this.gameObject.GetComponent<NavMeshAgent2D>().speed = GameVars.whiteCellSpeed;
    }
}
