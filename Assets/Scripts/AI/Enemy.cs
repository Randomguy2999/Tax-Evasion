using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _MaxHealth = 5;
    [SerializeField] private int _CurrentHealth = 5;

    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        Bullet bullet = col.GetComponent<Bullet>();


        if (bullet != null)
        {
            _CurrentHealth--;
            StartCoroutine(BeeEnemyDamage(1f));
            if (_CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }


        }


    }

    IEnumerator BeeEnemyDamage(float seconds)
    {
        _anim.SetBool("Damaged", true);
        yield return new WaitForSeconds(seconds);
        _anim.SetBool("Damaged", false);

    }
}
