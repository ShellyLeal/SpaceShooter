using UnityEngine;

public class Game : MonoBehaviour
{
    int Score;
    static Game Instance;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);
    }

    public static void AddToScore(int points)
    {
        Instance.Score += points;
    }
    public static int GetScore()
    {
        return Instance.Score;
    }

}