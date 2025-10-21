using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float Score;

    public TextMeshPro ScoreBoard;

    void Update()
    {
        Score += 0.01f;

        ScoreBoard.text = Score.ToString();
    }
}
