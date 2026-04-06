using UnityEngine;

public class RadiationEnemy : enemy
{
    [SerializeField] private float minDamage, maxDamage;
    
    public override void Attack(character toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        toHit.TakeDamage(damage);
    }
}
