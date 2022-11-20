using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add this script as a component to any game object you want to rotate.
public class Rotator : MonoBehaviour
{
    [SerializeField] private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * transform.up);
    }
}
