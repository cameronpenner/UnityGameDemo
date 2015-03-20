using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour
{
    public int _reloadTime;
    public Rigidbody _bullet;
    public int _shootSpeed;

    private int _reloadTimeLeft;
    private bool _readyToShoot;
    private Camera _camera;

	// Use this for initialization
	void Start ()
	{
	    _readyToShoot = true;
	    _camera = transform.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
	
        if (!_readyToShoot)
        {
            _reloadTimeLeft--;
            if (_reloadTimeLeft == 0)
            {
                _readyToShoot = true;
            }
        }

        if (Input.GetButton("Fire") && _readyToShoot)
        {
            _readyToShoot = false;
            _reloadTimeLeft = _reloadTime;

            var bullet = Instantiate(_bullet, transform.FindChild("Gun").transform.position, _camera.transform.rotation) as Rigidbody;
            bullet.AddForce(transform.forward * _shootSpeed);
        }
	}
}
