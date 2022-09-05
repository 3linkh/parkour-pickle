using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    [SerializeField] TMP_Text moneyText;
    [SerializeField] int money;
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Dil: " + money;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetMoney(int moneyIncrease)
    {
        money += moneyIncrease;

        moneyText.text = "Dil: " + money;

    }
}
