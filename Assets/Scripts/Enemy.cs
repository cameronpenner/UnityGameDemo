using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
            Debug.Log("OH SNAP"+col.gameObject.tag);
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
