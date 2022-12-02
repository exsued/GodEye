using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 direction = new Vector3(1f, 1f, 1f);
    

    public float speed = 1f;
    
    float b()
    {
        return Mathf.Sin(Time.time);
    }
    void Update()
    {
        direction.Normalize();
        transform.Rotate(direction * speed);
        //direction = new Vector3(b() * direction.x, b() * direction.y, b() * direction.z);
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + rotateAngle * speed);
    }
}
