using UnityEngine;

public class ZombieEnemy : enemy
{
    [SerializeField] private float minDamage, maxDamage;
    [SerializeField] private float criticalDamage = 0.80f;
    
    public override void Attack(character toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        if (Random.value > criticalDamage)
        {
            damage *= 2;
            Debug.Log("Big hit!");
        }
        toHit.TakeDamage(damage);
    }
}
