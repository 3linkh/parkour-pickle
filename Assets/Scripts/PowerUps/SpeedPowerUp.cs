using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedPowerUp : MonoBehaviour
{
    
    [SerializeField] PowerUpManager player;
    [SerializeField] CanvasManager canvasManager;
    [SerializeField] Money money;
    [SerializeField] Button speedPowerUpButton; 
    [SerializeField] int powerUpCost = 25;

    public void Start()
    {
        speedPowerUpButton = GetComponent<Button>();
        
        speedPowerUpButton.onClick.AddListener(TaskOnClick);
        
    }
     
    void TaskOnClick()
    {
            player.ApplySpeedPowerUp();
            SpendMoneyOnSpeedPowerUp();
        
            canvasManager.CloseCanvasAfterSelection();
        
    }

    public void SpendMoneyOnPowerUp(int moneySpent)
    {
        powerUpCost = moneySpent;
        money.GetMoney(-moneySpent);
    }

    void SpendMoneyOnSpeedPowerUp()
    {
        SpendMoneyOnPowerUp(powerUpCost);

    }
}
