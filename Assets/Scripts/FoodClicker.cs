using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodClicker : MonoBehaviour
{
    public ParticleSystem EX;
    private ParticleSystem EX2;
    public AudioSource source;
    private AudioSource Inssource;
    public AudioClip clip;
    private Vector3 spawnpos;
    private void OnMouseDown() 
    {
        if(GameVars.Hunger < 100)
        {
            GameVars.Hunger += 1;
            GameVars.Coin += 1;
            if (GameVars.Health >= 80 && GameVars.Health < 100)
            {
                GameVars.Health += 1;
            }
        }
        spawnpos = new Vector3(this.transform.position.x,this.transform.position.y,-11.7f);
        EX2 = Instantiate(EX,spawnpos,Quaternion.identity);   
        EX2.Play();
        Inssource = Instantiate(source,new Vector3(0,0,-1f),Quaternion.identity);
        Inssource.PlayOneShot(clip,10);
        Destroy(this.gameObject);
    }
}
