using UnityEngine;

public class Hazard : BlockInteract
{
    [SerializeField] BlockLostAction OnBlockDestroyed;

    protected override void HandleInteraction(GameObject block)
    {
        if (!IsSameColor(block))
        {
            if (IsSelected(block))
            {
                Destroy(block);
                OnBlockDestroyed.Raise();
            }
            else
            {
                Destroy(block);
            }
        }
    }
}
