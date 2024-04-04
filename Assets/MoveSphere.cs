using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    // Хранилище кадровой анимацммм
    [SerializeField] private AnimationCurve 
        _movingCurve;
    // Текущее время
    private float 
        currentTime;
    // Всё время
    private float 
        totalTime;
    // Компонент Transofrm
    private Transform 
        pos;

    void Start()
    {
        totalTime = _movingCurve.keys[_movingCurve.keys.Length - 1].time;
        pos = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        // Меняем положение объекта с учетом выбранной траектории
        gameObject.transform.position = new Vector3(pos.position.x, _movingCurve.Evaluate(currentTime), pos.position.z);

        // Текущее время меняется с учетом вызова FixedUpdate
        currentTime += Time.fixedDeltaTime;

        // Если анимания закончилась (Время анимации выше или равно указанной траектории) = ставим на начальную позицию
        if (currentTime >= totalTime)
        {
            currentTime = 0;
        }
    }
}
