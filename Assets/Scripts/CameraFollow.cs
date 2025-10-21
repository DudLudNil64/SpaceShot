using Unity.Mathematics;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Vector3 Offset;
    [SerializeField] Vector3 CameraRotation;
    public Transform Player;
    void LateUpdate()
    {
        transform.position = Offset + Player.position;
        transform.rotation = Quaternion.Euler(CameraRotation);
    }
}
