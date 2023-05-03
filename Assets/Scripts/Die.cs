using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject youdied;

    private void Update()
    {
        if (GameVars.Health <= 0)
        {
            youdied.SetActive(true);
            GameVars.Health = 0;
            Invoke("quit",3);
        }
    }
    public void quit()
    {
        Application.Quit();
    }
}
