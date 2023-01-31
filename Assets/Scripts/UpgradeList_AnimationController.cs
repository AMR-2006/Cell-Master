using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeList_AnimationController : MonoBehaviour
{

    public GameObject UI;

    public void Play_Show()
    {
        UI.GetComponent<Animator>().SetBool("IsShow",true);
        UI.GetComponent<Animator>().SetBool("IsHide",false);
    }
    public void Play_Hide()
    {
        UI.GetComponent<Animator>().SetBool("IsShow",false);
        UI.GetComponent<Animator>().SetBool("IsHide",true);
    }
}
