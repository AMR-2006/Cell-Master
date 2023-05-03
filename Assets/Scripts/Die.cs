using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject youdied;
    public AudioSource source;

    private void Update()
    {
        if (GameVars.Health <= 0)
        {
            youdied.SetActive(true);
            source.enabled = true;
            GameVars.Health = 0;
        }
    }
}
