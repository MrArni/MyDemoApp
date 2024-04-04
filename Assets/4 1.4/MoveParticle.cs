using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MoveParticle - название вашего класса!!!!
public class MoveParticle : MonoBehaviour
{
    public float
        speedMove = 5f;

    void Update()
    {
        float
            // Получаем клик по сторонам (влево, вправо)
            horInput = Input.GetAxis("Horizontal"),
            // Получаем клик по направлению (вперед, назад)
            verInput = Input.GetAxis("Vertical");

        Vector3
            // Получаем вектор с разницей направления
            direction = new Vector3(horInput, 0.0f, verInput);

        // Меняем положение объекта
        transform.Translate(direction * speedMove * Time.deltaTime);
    }
}
