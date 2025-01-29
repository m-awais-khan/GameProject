using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonColorChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text buttonText; // Assign the Legacy UI Text component
    public Image buttonImage; // Assign the Button's Image component

    private Color originalTextColor;
    private Color originalImageColor;

    void Start()
    {
        if (buttonText != null)
            originalTextColor = buttonText.color; // Store original text color

        if (buttonImage != null)
            originalImageColor = buttonImage.color; // Store original button color
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (buttonText != null)
            buttonText.color = Color.red; // Change text color to red

        if (buttonImage != null)
            buttonImage.color = Color.red; // Change button background to gray
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (buttonText != null)
            buttonText.color = originalTextColor; // Reset text color

        if (buttonImage != null)
            buttonImage.color = originalImageColor; // Reset button color
    }
}
