using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bullet")
        {
            Debug.Log("OH SNAP"+col.transform);
            Destroy(gameObject);
        }
    }
}
