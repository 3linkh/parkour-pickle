using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 40f;
    [SerializeField] int moneyValue = 5;
    [SerializeField] Money playerMoney;
        
    private void Start()
    {
        playerMoney = FindObjectOfType<Money>();
    }

    public void GetDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            playerMoney.GetMoney(moneyValue);
            Destroy(gameObject);
            
            Debug.Log((moneyValue));
            
        }
    }
}
