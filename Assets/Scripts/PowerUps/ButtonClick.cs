using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] PowerUpManager player;
    [SerializeField] CanvasManager canvasManager;
    [SerializeField] Money money;
    [SerializeField] Button powerUpButton1; // need to be powerupButton1, 2, 3 etc.?
    [SerializeField] Button powerUpButton2;
    [SerializeField] int powerUpCost = 25;

    bool powerUp1IsActive = false;
    bool powerUp2IsActive = false;

    // Start is called before the first frame update
    public void Start()
    {
        if (powerUpButton1 != null)
        {
            powerUp1IsActive = true;
        }
        if (powerUpButton2 != null)
        {
            powerUp2IsActive = true;
        }
        // set powerUpButton bool to true
        // in task below: if bool true then impliment x powerup

        //TODO find out why not closing on first click

        powerUpButton1 = GetComponent<Button>();
        
        powerUpButton1.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    
    void TaskOnClick()
    {
        if (powerUp1IsActive)
        {
            player.TurnOnGarlicShooter();
            Debug.Log("You Clicked a powerup1 Button!");
            SpendMoneyOnGarlicShooter();
        }
        else if (powerUp2IsActive)
        {
            Debug.Log("PowerUp2 is active and clicked");
        }

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
