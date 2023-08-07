using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCar : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] Vector3 _offset = new Vector3(0f, 5f, -10f); // Отступ от машины по оси Y и Z
    [SerializeField] float _rotationSpeed = 15f; // Уменьшенная скорость поворота камеры

    
    void LateUpdate()
    {
        if (_target != null)
        {
            // Получаем позицию, на которую должна смотреть камера (центр машины)
            Vector3 targetPosition = _target.position;
            
            // Устанавливаем позицию камеры равной цели с учетом отступа
            transform.position = targetPosition;
            
            
            // Вычисляем угол поворота камеры
            float targetAngle = _target.eulerAngles.y;
            float currentAngle = transform.eulerAngles.y;
            float angle = Mathf.LerpAngle(currentAngle, targetAngle, _rotationSpeed * Time.deltaTime);
            
            // Применяем поворот к камере
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, angle, transform.eulerAngles.z);
        }
    }
}
