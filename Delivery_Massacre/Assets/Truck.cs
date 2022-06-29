using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{

    [SerializeField] float steerSpeed = 50f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float afterBoost = 10f;
    bool crossedBoost;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float steerDirection = 0;

        if (!crossedBoost) {
            steerDirection = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        } else {
            steerDirection = Input.GetAxis("Vertical") * afterBoost * Time.deltaTime;
            counter++ ;
        }
        
        if (steerDirection >= 0)
        {
            steerAmount = steerAmount * (-1);
        }
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, steerDirection, 0);

        if (counter > 200) {
            crossedBoost = false;
            counter = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Boost") {
            crossedBoost = true;
        }
    }
}