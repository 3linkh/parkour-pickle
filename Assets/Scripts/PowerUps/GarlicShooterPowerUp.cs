using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarlicShooterPowerUp : MonoBehaviour
{
    

    [SerializeField] PowerUpManager player;
    [SerializeField] CanvasManager canvasManager;
    [SerializeField] Money money;
    [SerializeField] Button garlicShooterPowerUpButton; // need to be powerupButton1, 2, 3 etc.?
    [SerializeField] int powerUpCost = 25;

    public void Start()
    {
        garlicShooterPowerUpButton = GetComponent<Button>();
        
        garlicShooterPowerUpButton.onClick.AddListener(TaskOnClick);
        
    }
     
    void TaskOnClick()
    {
            player.TurnOnGarlicShooter();
            Debug.Log("You Clicked a powerup1 Button!");
            SpendMoneyOnGarlicShooter();
        
            canvasManager.CloseCanvasAfterSelection();
        
    }

    public void SpendMoneyOnPowerUp(int moneySpent)
    {
        powerUpCost = moneySpent;
        money.GetMoney(-moneySpent);
    }

    void SpendMoneyOnGarlicShooter()
    {
        SpendMoneyOnPowerUp(powerUpCost);

    }
}
