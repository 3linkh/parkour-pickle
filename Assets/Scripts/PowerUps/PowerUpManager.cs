using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    //public List <string> powerUps = new List <string>();
   ParticleSystem particleSystem;
   float thisJumpForce;
   float thisSpeedForce;
   [SerializeField] float jumpBoostAmount = 5f;
   [SerializeField] float speedBoostAmount = 5f;

    bool hasJumpPowerUp = false;
    void Start()
    {
        particleSystem = GetComponentInChildren<ParticleSystem>();
        particleSystem.gameObject.SetActive(false);  

        thisJumpForce = GetComponent<PlayerMovement>().jumpSpeed;
    }
    public void JumpPowerUp(float jumpForce)
    {
        
        jumpForce = jumpForce + jumpBoostAmount;
        GetComponent<PlayerMovement>().jumpSpeed = jumpForce;
        Debug.Log(jumpForce);
        
    }

    public void TurnOnGarlicShooter()
    {
        Debug.Log("TurnonGarlic Method attemp");
        particleSystem.gameObject.SetActive(true);
    }

    public void ApplyJumpPowerUp()
    {
        JumpPowerUp(thisJumpForce);
        Debug.Log("Click is working");
    }

    public void SpeedPowerUp(float speedForce)
    {
        speedForce = speedForce + speedBoostAmount;
        GetComponent<PlayerMovement>().maximumSpeed = speedForce;
        Debug.Log(speedForce);
    }

    public void ApplySpeedPowerUp()
    {
        SpeedPowerUp(thisSpeedForce);
    }

}
