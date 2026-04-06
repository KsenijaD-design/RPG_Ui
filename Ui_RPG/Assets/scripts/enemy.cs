using UnityEngine;

public abstract class enemy : character
{
    [SerializeField] private Sprite enemyImage;
    
    
    public Sprite EnemyImage
    {
        get { return enemyImage; }
    }
    
    public override void Attack(character toHit)
    {
       
    }

    public override void Die()
    {
        FindObjectOfType<GameManager>().SpawnNewEnemy();
        Destroy(gameObject); 
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
