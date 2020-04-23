using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorBlinkerUI : MonoBehaviour
{
    public float FadeDuration = 1f;
    public Color Color1 = Color.gray;
    public Color Color2 = Color.white;
    public bool disabled;

    private Color startColor;
    private Color endColor;
    private float lastColorChangeTime;

    private Image image;
    void Start()
    {
        image = GetComponent<Image>();
        startColor = Color1;
        endColor = Color2;
    }

    void Update()
    {
        if (!disabled)
        {
            var ratio = (Time.time - lastColorChangeTime) / FadeDuration;
            ratio = Mathf.Clamp01(ratio);
            image.color = Color.Lerp(startColor, endColor, ratio);
            //image.color = Color.Lerp(startColor, endColor, Mathf.Sqrt(ratio)); // A cool effect
            //image.color = Color.Lerp(startColor, endColor, ratio * ratio); // Another cool effect

            if (ratio == 1f)
            {
                lastColorChangeTime = Time.time;

                // Switch colors
                var temp = startColor;
                startColor = endColor;
                endColor = temp;
            }
        }
    }
}
