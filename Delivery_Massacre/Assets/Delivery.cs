using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackege;
    bool isLoaded;

    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Hello, I collided!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag =="Package" && !isLoaded) {
            Debug.Log("Package has been picked up.");
            hasPackege = true;
            isLoaded = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, 1f);
        }

        if(other.tag == "Customer" && hasPackege ) {
            Debug.Log("Delivery successful");
            hasPackege = false;
            isLoaded = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
