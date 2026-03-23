using UnityEngine;

public class Blade : Weapon
{
    public float mindamage, maxdamage;
    public override float GetDamage()
    {
        return Random.Range(mindamage, maxdamage);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
