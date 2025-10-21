using UnityEngine;

public class BasicEnemyManager : MonoBehaviour
{
    enum EnemyType
    {
        NONE,
        Static,
        Moving,
        Tracker
    }

    EnemyType enemyType;
    float Health;

    void Update()
    {
        switch (enemyType)
        {
            case EnemyType.NONE:
                Debug.Log("Stupid You Forgot To Set This Value");
                break;
            case EnemyType.Static:
                break;
            case EnemyType.Moving:
                break;
            case EnemyType.Tracker:
                break;
        }
    }

    void ShotPlayer()
    {

    }
}
