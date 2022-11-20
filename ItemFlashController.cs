using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add this script as a component to the Particle System flash animation.
public class ItemFlashController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
