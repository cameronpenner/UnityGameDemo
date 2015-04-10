using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public int Health = 10;

    void OnCollisionEnter(Collision col)
    {
            Debug.Log("OH SNAP"+col.gameObject.tag);
        if (col.gameObject.tag == "Bullet")
        {
            Health--;
            if(Health <= 0)
                Destroy(gameObject);
        }
    }
}
