using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    [SerializeField] ParticleSystem garlicProjectile;
    
    // Start is called before the first frame update
    private void Awake()
    {
        garlicProjectile = GetComponentInChildren<ParticleSystem>();
    }
    void Start()
    {
        garlicProjectile.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        FireGarlicProjectile();
               
    }

    public void FireGarlicProjectile()
    {
        if (Input.GetMouseButtonDown(0))
        {
            garlicProjectile.Play();
        }
    }

    


    
}
