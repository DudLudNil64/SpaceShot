using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] KeyCode Shot = KeyCode.Space;

    public GameObject Bullet;


    void Update()
    {
        if (Input.GetKey(Shot))
        {
            SpawnBullet(transform.position);
        }
        
    }

    void SpawnBullet(Vector3 BulletOrigin)
    {
        Instantiate(Bullet, BulletOrigin, Quaternion.identity);
    }
}
