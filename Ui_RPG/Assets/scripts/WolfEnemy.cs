using UnityEngine;

public class WolfEnemy : enemy
{
    [SerializeField] private float minWolfDamage, maxWolfDamage;
    
    public override void Attack(character toHit)
    {
        float damage = Random.Range(minWolfDamage, maxWolfDamage);
        toHit.TakeDamage(damage);
    }
}
