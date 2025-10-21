using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(transform.forward * 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            BasicEnemyManager EM = other.gameObject.GetComponent<BasicEnemyManager>();
        }
    }
}
