using UnityEngine;

[RequireComponent(typeof(ColorSetter), typeof(Collider))]
public class ColorDistributor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) => collision.GetComponent<ColorSetter>()?.SetColor(ref GetComponent<ColorSetter>().colorValue);
}
