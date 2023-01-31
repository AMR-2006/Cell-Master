using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyAftertime", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestroyAftertime()
    {
        Destroy(this.gameObject);
    }
}
