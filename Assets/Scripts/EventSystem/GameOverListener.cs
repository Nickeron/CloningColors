using UnityEngine;
using UnityEngine.Events;

public class GameOverListener : GameFunctionListener<GameValues>
{
    [SerializeField] UnityEvent<GameValues> OnGameOver;
    public override void OnEventRaised(GameValues updateContent)
    {
        OnGameOver.Invoke(updateContent);
    }
}

public struct GameValues
{
    public bool isWin;
    public int Score;
}
