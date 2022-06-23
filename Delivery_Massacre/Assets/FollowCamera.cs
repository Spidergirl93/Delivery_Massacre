using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject mainVehicle;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = mainVehicle.transform.position + new Vector3(0, 0, -15);
    }
}
