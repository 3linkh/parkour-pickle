using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    
    [SerializeField] ParticleSystem myParticleSystem;
          
    void OnTriggerEnter(Collider other) 
    {
        myParticleSystem.Play();
    }
}
