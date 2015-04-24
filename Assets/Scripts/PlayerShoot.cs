using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    public float _reloadTime;
    public Rigidbody _bullet;
    public float _shootSpeed;

    private float _reloadTimeLeft;
    private bool _readyToShoot;

	void Start ()
	{
	    _readyToShoot = true;
	}
	
	void FixedUpdate ()
    {
        if (!_readyToShoot)
        {
            _reloadTimeLeft -= Time.deltaTime;
            if (_reloadTimeLeft <= 0)
            {
                _readyToShoot = true;
            }
        }

        if (Input.GetButton("Fire") && _readyToShoot)
        {
            _readyToShoot = false;
            _reloadTimeLeft = _reloadTime;

            var bullet = Instantiate(_bullet, transform.position, transform.rotation) as Rigidbody;
            bullet.AddForce(transform.forward * _shootSpeed);
        }
	}
}
