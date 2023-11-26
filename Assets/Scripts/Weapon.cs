using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _silencer;
    [SerializeField] private float _maxDistance = 100f;
    [SerializeField] private Animator _animator;
    [SerializeField] private int _weaponSpace = 10;
    private int _numberOfBulletInWeapon;
    private void Start()
    {
        _numberOfBulletInWeapon = _weaponSpace;
    }
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
        if (_numberOfBulletInWeapon == 0) return;
        _animator.SetTrigger("Fire");
        _numberOfBulletInWeapon --;
        //if (Physics.Raycast(_silencer.position,transform.forward, _maxDistance)) 
        //{
        //    Debug.Log("Hit");
        //}
    }
    private void Reload() 
    {
        _numberOfBulletInWeapon = _weaponSpace;
        _animator.SetTrigger("Reload");
    }
}
