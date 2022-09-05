using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    [SerializeField] GameObject pizza;
    [SerializeField] Canvas canvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pizza.SetActive(true);
            canvas.enabled = true;
        }    
    }
}
