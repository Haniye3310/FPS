using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _silencer;
    [SerializeField] private float _maxDistance = 100f;
    [SerializeField] private Animator _animator;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            Reload();
        }
    }
    private void Shoot() 
    {
        _animator.SetTrigger("Fire");
        //if (Physics.Raycast(_silencer.position,transform.forward, _maxDistance)) 
        //{
        //    Debug.Log("Hit");
        //}
    }
    private void Reload() 
    {
        _animator.SetTrigger("Reload");
    }
}
