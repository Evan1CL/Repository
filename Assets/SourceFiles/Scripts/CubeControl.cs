using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // s = u t          s distance = u (velocity) * t (time)
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.position += 0.01f * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.position += 0.01f * Vector3.right;
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            transform.position += 0.01f * Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            transform.position += 0.01f * Vector3.left;
        }
        if (Input.GetKey(KeyCode.LeftControl)) 
        {
            transform.position += 0.01f * Vector3.down;
        }
        if (Input.GetKey(KeyCode.Space)) 
        {
            transform.position += 0.01f * Vector3.up;
        }


    }
}
