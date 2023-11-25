using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed = 12f;
    [SerializeField] private Animator _animator;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (x == 0 && z == 0) 
        {
            _animator.SetBool("Walk", false); return; 
        }
        Vector3 move = transform.right * x + transform.forward * z;
        _characterController.Move(move * _speed * Time.deltaTime);
        _animator.SetBool("Walk", true);
    }
}
