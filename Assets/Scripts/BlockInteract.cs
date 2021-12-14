using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class BlockInteract : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block")) HandleInteraction(collision.gameObject);
    }

    protected abstract void HandleInteraction(GameObject block);

    protected bool IsSelected(GameObject block) => block.GetComponent<BlockMovement>()?.isActiveBool ?? false;

    protected bool IsSameColor(GameObject block) => block.GetComponent<ColorSetter>()?.colorValue == GetComponent<ColorSetter>()?.colorValue;
}
