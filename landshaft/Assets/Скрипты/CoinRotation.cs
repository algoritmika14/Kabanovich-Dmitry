using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {

    float smooth = 5.0f;
    float tiltAngle = 60.0f;
    float tiltAroundY = 0f;
    
    void Update()
    {
        tiltAroundY += 1f;
       
        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(90, tiltAroundY, 0);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        
    }
}
