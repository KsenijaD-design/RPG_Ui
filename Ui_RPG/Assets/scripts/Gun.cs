using UnityEngine;

public class Gun : Weapon
{
    public float mindamage, maxdamage, bestdamage;
    public float goodShot = 0.80f;
    public override float GetDamage()
    {
        if (Random.value > goodShot)
        {
            return Random.Range(maxdamage, bestdamage);
        }
        else
        {
            return Random.Range(mindamage, bestdamage);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
