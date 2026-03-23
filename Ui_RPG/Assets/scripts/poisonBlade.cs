using UnityEngine;

public class poisonBlade : Blade
{
    [SerializeField] float poisonDamage;
    [SerializeField] int poisonCount;

    public override float GetDamage()
    {
        float baseDmanage = base.GetDamage();
        if (poisonCount > 0)
        {
            poisonCount--;
            return baseDmanage + poisonDamage;
        }
        return baseDmanage;
    }
}
