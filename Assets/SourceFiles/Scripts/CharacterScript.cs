using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public GameObject bulletCloneTemplate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Instantiate(bulletCloneTemplate, transform.position , transform.rotation);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }
}
