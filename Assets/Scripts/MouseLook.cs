using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float _mouseSensivity = 100f;
    [SerializeField] private Transform _playerTransform;
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensivity * Time.deltaTime;
        _playerTransform.Rotate(Vector3.up * mouseX);
    }
}
