using UnityEngine;


public class MainCameraControls : MonoBehaviour
{
    public GameObject player; // References the player's position 
    private Vector3 offset; // References the offset distance from player 
    // Start is called before the first frame update
    void Start()
    {  
      offset = transform.position - player.transform.position; 
    }
           
        
  // Update is called every frame 

    void Update()
    {
      transform.position = player.transform.position + offset;

    }

}

