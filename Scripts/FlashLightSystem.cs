using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = 0.1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minimumAngle = 40f;

    Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensisty();
    }

    void DecreaseLightAngle()
    {
        if (myLight.spotAngle <= minimumAngle) { return; }
        myLight.spotAngle -= angleDecay * Time.deltaTime;
    }

    void DecreaseLightIntensisty()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
    }

    public void RestoreLightAngle(float restorAngle)
    {
        myLight.spotAngle = restorAngle;
    }

    public void AddLightIntensity(float intensityAmount)
    {
        myLight.intensity += intensityAmount;
    }
}
