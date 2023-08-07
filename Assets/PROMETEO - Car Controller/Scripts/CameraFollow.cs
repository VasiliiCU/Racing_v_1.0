using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform carTransform;
    [Range(0.01f, 1.0f)]
    public float followSpeed = 0.05f; // Уменьшили значение для более плавного движения камеры
    [Range(1, 10)]
    public float lookSpeed = 3;

    private Vector3 currentVelocity; // Добавили переменную для SmoothDamp

    void FixedUpdate()
    {
        //Look at car
        Vector3 _lookDirection = carTransform.position - transform.position;
        Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookSpeed * Time.deltaTime);

        //Move to car using SmoothDamp
        Vector3 _targetPos = carTransform.position;

        // Плавно перемещаем камеру к целевой позиции
        transform.position = Vector3.SmoothDamp(transform.position, _targetPos, ref currentVelocity, followSpeed);
    }
}
