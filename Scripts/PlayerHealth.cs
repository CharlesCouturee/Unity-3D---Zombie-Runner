using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    DeathHandler deathHandler;

    void Start()
    {
        deathHandler = GetComponent<DeathHandler>();
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            deathHandler.HandleDeath();
        }
    }
}
