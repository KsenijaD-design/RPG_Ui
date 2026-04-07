using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string weaponName;
    [SerializeField] private Sprite weaponImage;
    
    public Sprite WeaponImage
    {
        get { return weaponImage; }
    }
    public abstract float GetDamage();
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
