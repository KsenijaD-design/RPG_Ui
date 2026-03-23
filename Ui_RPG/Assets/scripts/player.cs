using UnityEngine;

public class player : character
{
    [SerializeField] private Weapon activeWeapon;
    
    public override void Attack(character toHit)
    {
        toHit.TakeDamage(activeWeapon);
        //float damage = activeWeapon.GetDamage();
        //toHit.TakeDamage(damage);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
