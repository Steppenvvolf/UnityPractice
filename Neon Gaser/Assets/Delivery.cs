using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);
    SpriteRenderer spriteRenderer;
    [SerializeField] float destroyDelay = 0.5f;
    
    void Start() {
        Debug.Log("Player package - " + hasPackage);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision_Present");
       
    }
    private void OnTriggerEnter2D(Collider2D other) 
        {
            //Debug.Log("Event_Triggered");  
            if (other.tag == "Package" && !hasPackage)
            {
                Debug.Log("Package Picked Up");
                hasPackage = true;
                spriteRenderer.color = hasPackageColor;
                Destroy(other.gameObject, destroyDelay);
            }

            if (other.tag == "Customer" && hasPackage)
            {
                Debug.Log("Package Delivered");
                hasPackage = false;
                spriteRenderer.color = noPackageColor;
            }
        }
}
