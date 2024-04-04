using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraToUser : MonoBehaviour
{
    public Transform
        target;
    public float
        height = 2f,
        distance = 5f,
        speed = 0.125f;

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3
                // Новое положение объекта
                pos = target.position - target.forward * distance + Vector3.up * height,
                // Плавная смена положения камеры к объекту
                pos_fix = Vector3.Lerp(transform.position, pos, speed);

            transform.position = pos_fix;
            transform.LookAt(target.position);
        }
    }
}
