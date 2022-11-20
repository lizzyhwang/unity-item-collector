using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add this class as a component to the character picking up the item.
public class CollectionHandler : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Tag of object to collect")]
    private string itemTag;
    [SerializeField]
    [Tooltip("Particle System to run when this item gets collected")]
    private ParticleSystem itemFlash;

    private GameObject item;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null)
        {
                Instantiate(itemFlash, item.transform.position, Quaternion.identity);
                Destroy(item);
        }
    }
    
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == itemTag && item == null)
        {
            item = col.gameObject;
        }
    }
}
