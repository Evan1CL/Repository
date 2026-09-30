using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float bulletSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += bulletSpeed *  transform.forward * Time.deltaTime;
    }
    public void OnCollisionEnter(Collision collision)
    {
        Health possibleVictim = collision.transform.GetComponent<Health>();
        if (possibleVictim)
            possibleVictim.takeDamage(25);
    }
}
