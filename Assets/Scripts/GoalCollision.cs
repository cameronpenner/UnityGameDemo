using UnityEngine;
using System.Collections;

public class GoalCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("found end");
        }
    }
}
