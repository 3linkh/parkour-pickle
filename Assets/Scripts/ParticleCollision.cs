using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    [SerializeField] float garlicProjectileDamage = 10f;
    EnemyHealth enemyHealth;

    
    
    void OnParticleCollision(GameObject other)
    {
        Debug.Log("something hit");
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("enemy hit");
            other.GetComponent<EnemyHealth>().GetDamage(garlicProjectileDamage);
        }
    }
}
