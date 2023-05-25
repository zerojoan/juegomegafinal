using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour


{
    BoxCollider2D boxCollider;
    SFXManager sfxManager;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }


    // Update is called once per frame
    public void Pick()
    {
        boxCollider.enabled = false;
        Destroy(this.gameObject);
        sfxManager.ObjectDestroy();


    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           
            Destroy(this.gameObject);
            sfxManager.ObjectDestroy();
        }
    }
}
