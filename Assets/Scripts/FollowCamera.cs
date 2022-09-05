using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform followCameraTarget;

    void Update()
    {
        transform.position = followCameraTarget.position;
    }
}
