using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera FPSCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;

    bool zoomedInToggle = false;

    void OnDisable()
    {
        zoomedInToggle = false;
        ZoomOut();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle)
            {
                ZoomOut();
            }
            else
            {
                ZoomIn();
            }
        }
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        FPSCamera.fieldOfView = zoomedOutFOV;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        FPSCamera.fieldOfView = zoomedInFOV;
    }
}
