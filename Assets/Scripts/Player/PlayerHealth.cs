using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _MaxHealth = 5;
    [SerializeField] private int _CurrentHealth = 5;

    private void OnCollisionEnter2D(Collision2D col)
    {
        Enemy enemy = col.gameObject.GetComponent<Enemy>();

        DeathZone deathZone = col.gameObject.GetComponent<DeathZone>();

        Spikedamage spike = col.gameObject.GetComponent<Spikedamage>();

        if (enemy != null)
        {
            _CurrentHealth--;

            if (_CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

        else if (deathZone != null)
        {
            _CurrentHealth = 0;

            if (_CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
        else if (spike != null)
        {
            _CurrentHealth --;

            if (_CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }



    }
}

