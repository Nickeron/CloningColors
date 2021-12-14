using System.Collections;

using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorSetter : MonoBehaviour
{
    public ColorValue colorValue = ColorValue.white;
    [SerializeField] AnimationCurve curve;

    SpriteRenderer mySpriteRenderer;

    void Awake() => mySpriteRenderer = GetComponent<SpriteRenderer>();
    void Start() => SetColor(ref colorValue);

    public void SetColor(ref ColorValue newValue)
    {
        colorValue = newValue;
        mySpriteRenderer.color = GameColor.Get(ref colorValue);
    }

    public void Flash()
    {
        StartCoroutine(FlashColorRoutine());
    }

    IEnumerator FlashColorRoutine()
    {
        float timeIndex = 0;
        while (timeIndex < 1)
        {
            SetAlpha(curve.Evaluate(timeIndex));
            timeIndex += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }

    void SetAlpha(float opacity)
    {
        var colr = mySpriteRenderer.color;
        mySpriteRenderer.color = new Color(colr.r, colr.g, colr.b, opacity);
    }
}
