using UnityEngine;

public class player : character
{
    [SerializeField] private Weapon activeWeapon;
    [SerializeField] private bool shieldActive = false;
    [SerializeField] private GameObject shield;
    [SerializeField] private float shieldProtection = 0.5f;
    [SerializeField] private float shieldBreak = 0.20f;
    
    public Weapon ActiveWeapon
    {
        get { return activeWeapon; }
    }

    public void SetWeapon(Weapon weapon)
    {
        activeWeapon = weapon;
    }
    public override void Attack(character toHit)
    {
        toHit.TakeDamage(activeWeapon);
        //float damage = activeWeapon.GetDamage();
        //toHit.TakeDamage(damage);
    }

    public override void Die()
    {
        FindObjectOfType<GameManager>().GameOver();
    }

    public void ShieldActive()
    {
        shieldActive = !shieldActive;
        shield.SetActive(shieldActive);
    }

    public override void TakeDamage(float damage)
    {
        if (shieldActive)
        {
            damage *= (1f - shieldProtection) ;
            if (Random.value < shieldBreak)
            {
                shieldActive = false;
                Debug.Log("Shield broken!");
            }
        }
        base.TakeDamage(damage);
    }
}
