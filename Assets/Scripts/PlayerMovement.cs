using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] KeyCode Up = KeyCode.W;
    [SerializeField] KeyCode Down = KeyCode.S;
    [SerializeField] KeyCode Left = KeyCode.D;
    [SerializeField] KeyCode Right = KeyCode.A;

    public Vector3 PlayerArea;

    void Update()
    {
        Vector3 MovmentVector = Vector3.zero;

        if (Input.GetKey(Up)) { MovmentVector += Vector3.forward; }
        if (Input.GetKey(Down)) { MovmentVector += Vector3.back; }
        if (Input.GetKey(Left)) { MovmentVector += Vector3.left; }
        if (Input.GetKey(Right)) { MovmentVector += Vector3.right; }

        transform.Translate(MovmentVector * (Time.deltaTime * 60));

        if (transform.position.x > PlayerArea.x) { transform.position = new Vector3(PlayerArea.x, transform.position.y, transform.position.z); }
        if (transform.position.x < -PlayerArea.x) { transform.position = new Vector3(-PlayerArea.x, transform.position.y, transform.position.z); }

        if (transform.position.z > PlayerArea.z) { transform.position = new Vector3(transform.position.x, transform.position.y, PlayerArea.z); }
        if (transform.position.z < -PlayerArea.z) { transform.position = new Vector3(transform.position.x, transform.position.y, -PlayerArea.z); }
    }
}
