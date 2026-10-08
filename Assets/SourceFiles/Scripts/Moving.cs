using UnityEngine;

public class Moving : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 2;
    private float MaxSpeed = 4;
    private float maxLinearVelocity = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            rb.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            rb.AddForce(Vector3.right * force);
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            rb.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.LeftControl)) 
        {
            rb.AddForce(Vector3.down * force);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force);
        }
        if (rb.linearVelocity.magnitude > MaxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * MaxSpeed;
        }
    }
}
