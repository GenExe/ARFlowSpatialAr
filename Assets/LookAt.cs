using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class LookAt : MonoBehaviour
{
    public Transform target;

    public void LookAtTarget()
    {
        transform.LookAt(target);
    }
}