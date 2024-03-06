
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;
    public bool shouldDestroy = true;

    public GameObject damageEffect;
    public GameObject deathEffect;

    public UnityEvent onDie;
    public UnityEvent onDamage;
    public AudioClip zombieSound;
    public AudioSource source;
    void Start()
    {
        if(health == 0) health = maxHealth;
    }


    public void Damage(int damage)
    {
        health -= damage;
        onDamage.Invoke();
        if(health <= 0)
        {
            Die();
        }
        if(health < 0)health = 0;
        if(damageEffect != null) Instantiate(damageEffect,transform.position,Quaternion.identity);
    }

    public void Die()
    {
        if(shouldDestroy)Destroy(gameObject);
        source.clip = zombieSound;
        source.Play();
        onDie.Invoke();
        if( deathEffect != null) Instantiate(deathEffect,transform.position,Quaternion.identity);
    }
}