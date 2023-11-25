using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _silencer;
    [SerializeField] private float _maxDistance = 100f;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
    }
    private void Shoot() 
    {
        if(Physics.Raycast(_silencer.position,transform.forward, _maxDistance)) 
        {
            Debug.Log("Hit");
        }
    }
}
