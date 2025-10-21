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
            SpawnBullet(transform.position + new Vector3(1, 0, 0));
            SpawnBullet(transform.position - new Vector3(1, 0, 0));
        }

    }

    void SpawnBullet(Vector3 BulletOrigin)
    {
        Instantiate(Bullet, BulletOrigin, Quaternion.identity);
    }
}
