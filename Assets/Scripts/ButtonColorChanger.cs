using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonColorChanger : Button
{
    private Image _image;
    private Color _startImageColor;

    protected override void Awake()
    {
        _image = GetComponent<Image>();
        _startImageColor = _image.color;
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        _image.color = Color.yellow;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        _image.color = _startImageColor;
    }
}
