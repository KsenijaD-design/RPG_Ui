using UnityEngine;

public class shocker : Weapon
{
    public float damage;
    public float damagechanse = 0.70f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override float GetDamage()
    {
        if (Random.value < damagechanse)
        {
            return damage;
        }

        return 0;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
