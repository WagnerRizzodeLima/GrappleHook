using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;

    private void Lateupdate()
    {
        transform.position = target.position;
    }
}
