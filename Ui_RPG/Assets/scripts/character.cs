using UnityEngine;

public abstract class character : MonoBehaviour
{
    public float health;
    [SerializeField] private string charName;

    public string CharName
    {
        get { return charName; }
    }

    public abstract void Attack(character toHit);

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(charName + " took " + damage + " damage. Health - " + health);
    }

    public void TakeDamage(Weapon thrownWeapon)
    {
        float damage = thrownWeapon.GetDamage();
        TakeDamage(damage);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
