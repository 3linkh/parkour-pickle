using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpPowerUp : MonoBehaviour
{
    [SerializeField] PowerUpManager player;
    [SerializeField] CanvasManager canvasManager;
    [SerializeField] Money money;
    [SerializeField] Button jumpPowerUpButton; 
    [SerializeField] int powerUpCost = 25;

    public void Start()
    {
        jumpPowerUpButton = GetComponent<Button>();
        
        jumpPowerUpButton.onClick.AddListener(TaskOnClick);
        
    }
     
    void TaskOnClick()
    {
            player.ApplyJumpPowerUp();
            SpendMoneyOnJumpPowerUp();
        
            canvasManager.CloseCanvasAfterSelection();
        
    }

    public void SpendMoneyOnPowerUp(int moneySpent)
    {
        powerUpCost = moneySpent;
        money.GetMoney(-moneySpent);
    }

    void SpendMoneyOnJumpPowerUp()
    {
        SpendMoneyOnPowerUp(powerUpCost);

    }
}
