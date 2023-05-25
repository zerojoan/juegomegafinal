using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip enemyDeath;
    private AudioSource source;
    public AudioClip Object;
    // Start is called before the first frame update
    void Awake()
    {
       source = GetComponent<AudioSource>();
    }


    public void EnemyDeath()
    {
        source.PlayOneShot(enemyDeath);
    }


    public void ObjectDestroy()


    {
        source.PlayOneShot(Object);
    }






     
     
}

