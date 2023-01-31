using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public void Startdestroying()
    {
        Invoke("DestroyShield",30f);
    }

    private void DestroyShield()
    {
        //yield return new WaitForSeconds(Time);
        this.gameObject.SetActive(false);
        GameVars.isShieldEnable = false;
    }
}
