using UnityEngine;

public class WinSpot : BlockInteract
{
    [SerializeField] GameOverFunction OnGameOver;
    
    protected override void HandleInteraction(GameObject block)
    {
        if(IsSameColor(block)) OnGameOver.Raise(new GameValues { isWin = true, Score = 0 });
    }
}
