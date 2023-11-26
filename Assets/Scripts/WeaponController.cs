using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private Transform _silencer;
    [SerializeField] private float _maxDistance = 100f;
    [SerializeField] private Animator _animator;
    [SerializeField] private int _magazine = 10;
    private int _numberOfBulletInWeapon;
    private void Start()
    {
        _numberOfBulletInWeapon = _magazine;
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
        RaycastHit hit;
        if (Physics.Raycast(_silencer.position, transform.forward, out hit, _maxDistance))
        {
            hit.rigidbody.AddForce(new Vector3(10,10,500));
        }
    }
    private void Reload() 
    {
        _numberOfBulletInWeapon = _magazine;
        _animator.SetTrigger("Reload");
    }
}
