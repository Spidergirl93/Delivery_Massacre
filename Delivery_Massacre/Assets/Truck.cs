using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{

    [SerializeField] float steerSpeed = 50f;
    [SerializeField] float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float steerDirection = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        if (steerDirection > 0f)
        {
            steerAmount = steerAmount * (-1);
        }
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, steerDirection, 0);

    }
}