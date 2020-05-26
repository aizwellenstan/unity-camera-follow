using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Func<Vector3> GetCameraFollowPositionFunc;
    public void Setup(Func<Vector3> GetCameraFollowPositionFunc)
    {
        this.GetCameraFollowPositionFunc = GetCameraFollowPositionFunc;
    }
    void Start ()
    {

    }

    void Update ()
    {
        // Vector3 CameraFollowPosition = new Vector3(0, 100);
        
        Vector3 cameraFollowPosition = GetCameraFollowPositionFunc();

        cameraFollowPosition.z = transform.position.z;
        transform.position = cameraFollowPosition;
    }
}