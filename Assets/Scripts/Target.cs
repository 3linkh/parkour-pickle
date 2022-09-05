using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] Camera cam;
        
    private void Start() 
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireRay();
        }
        
        //InteractWithFocusTarget();
    }

    public void FireRay()
    {
        Ray ray =   cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;
        
        if (Physics.Raycast(ray, out hitData))
        {
            FocusTarget target = hitData.transform.GetComponent<FocusTarget>();
            if (target == null) return;
            Debug.Log(target.transform.position);
            SetFocus(target);
        }
        

        
        
    }

    public void SetFocus(FocusTarget target)
    {
        gameObject.transform.LookAt(target.transform.position);
    }

    // void InteractWithFocusTarget()
    // {
    //     RaycastHit [] hits = Physics.RaycastAll(ray);
    //     foreach (RaycastHit hit in hits)
    //     {
    //         FocusTarget target = hit.transform.GetComponent<FocusTarget>();
    //         if (target == null) continue;

    //         if (Input.GetMouseButtonDown(0))
    //         {
    //             SetFocus(target);
    //         }
    //     }
    // }

    // // private Ray GetMouseRay()
    // // {
    // //     return Camera.main.ScreenPointToRay(Input.mousePosition);
    // // }

    // public void SetFocus(FocusTarget target)
    // {
    //     print(target);
    // }

}
