using UnityEngine;

public class Currency : BlockInteract
{
    protected override void HandleInteraction(GameObject block)
    {
        if (IsSameColor(block))
        {
            Destroy(gameObject);
            return;
        }
        GetComponent<ColorSetter>().Flash();

    }
}
