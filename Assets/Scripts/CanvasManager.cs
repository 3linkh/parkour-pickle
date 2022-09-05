using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    [SerializeField] float canvasCloseDelay = 0.2f;
    [SerializeField] GameObject powerUpButton1;
    [SerializeField] GameObject powerUpButton2;
    [SerializeField] GameObject powerUpButton3;
    
    private PlayerMovement playerMovement;

    
    void Start()
    {
        CloseCanvas();
        playerMovement = GetComponent<PlayerMovement>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            canvas.gameObject.SetActive(true);
            //SpawnButtons();
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            
        }

    }

    public void CloseCanvasAfterSelection()
    {
        
            Time.timeScale = 1;
            StartCoroutine("DelayedCloseCanvas");
        
    }

    IEnumerator DelayedCloseCanvas()
    {
        yield return new WaitForSeconds(canvasCloseDelay);
        CloseCanvas();
        //Destroy(gameObject);
        
    }

    void CloseCanvas()
    {
        canvas.gameObject.SetActive(false);
    }
    
    // void SpawnButtons()
    // {
    //         GameObject button = Instantiate(powerUpButton1) as GameObject;
    //         button.transform.SetParent(canvas.transform, false); 

    //         GameObject button2 = Instantiate(powerUpButton2) as GameObject;
    //         button2.transform.SetParent(canvas.transform, false);
    // }

}
