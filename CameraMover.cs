using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour
{
    private Transform playerTransform;

    private void Awake()
    {
        playerTransform = Object.FindObjectOfType<Player>().transform;
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -1);
    }
}