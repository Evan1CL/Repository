using UnityEngine;

public class Health : MonoBehaviour
{
    int MHP = 100;
    int CHP = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void takeDamage(int howMuchDamage)
    {
        CHP -= howMuchDamage;
        if (CHP<=0)
        {
            Destroy(gameObject);
        }
    }
}
