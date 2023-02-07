using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //public GameObject EX;
    //private GameObject EX2;
    public float Health;
    public AudioSource source;
    private AudioSource Inssource;
    public AudioClip clip;
    private Vector3 spawnpos;
    // Start is called before the first frame update
    void Start()
    {
        Health = GameVars.EnemyMainHealth;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        //spawnpos = new Vector3(this.transform.position.x,this.transform.position.y,-11.7f);
        //EX2 = Instantiate(EX,spawnpos,Quaternion.identity);
        
        Inssource = Instantiate(source,new Vector3(0,0,-1f),Quaternion.identity);
        Inssource.Play();
        if(Health > 0)
        {
            Health -= GameVars.Damage_Per_Click;
        }

        if(Health <= 0)
        {
            GameVars.Coin += 10;
            Inssource = Instantiate(source,new Vector3(0,0,-1f),Quaternion.identity);
            Inssource.PlayOneShot(clip, 10);
            Destroy(this.gameObject);
            GameVars.EnemyHittingPlayer -= 1;
        }
        
    }

}
