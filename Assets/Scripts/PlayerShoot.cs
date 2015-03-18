using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            var floor = GameObject.FindGameObjectWithTag("Obstacle");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, floor.layer))
                Debug.DrawLine(ray.origin, hit.point);


            Debug.Log("" + hit.point.x + ", " + hit.point.y + ", " + hit.point.z);
            //GameObject.Instantiate();
        }
    }
}
