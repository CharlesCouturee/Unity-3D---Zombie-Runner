using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float damage = 40f;
    [SerializeField] AudioClip attackSound;
    

    PlayerHealth target;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    public void AttackHitEvent()
    {
        if (target)
        {
            if (attackSound)
            {
                AudioSource.PlayClipAtPoint(attackSound, transform.position);
            }
            target.TakeDamage(damage);
            target.GetComponent<DisplayDamage>().showDamageImpact();
        }
    }
}
