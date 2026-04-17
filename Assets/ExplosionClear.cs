using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionClear : MonoBehaviour
{
    private ParticleSystem particleSmoke;
   private void Awake()
    {
        particleSmoke = GetComponentInChildren<ParticleSystem>();
    
    }
   
   private void update()
    {
        if(!particleSmoke.IsAlive())
        {
            Destroy(gameObject);
        }
    }
   
   
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
