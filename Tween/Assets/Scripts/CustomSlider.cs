using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class CustomSlider : Slider
{
    public static string ChangeButtonType => nameof(_animationType);
    public static string CurveEase => nameof(_curveEase);
    public static string Duration => nameof(_duration);

    [SerializeField]
    private AnimationType _animationType = AnimationType.Appearance;

    [SerializeField]
    private Ease _curveEase = Ease.Linear;

    [SerializeField]
    private float _duration = 2.0f;

    private RectTransform _rectTransform;

    protected override void Awake()
    {
        base.Awake();

        _rectTransform = GetComponent<RectTransform>();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        ActivateAnimation();
    }

    private void ActivateAnimation()
    {
        switch (_animationType)
        {
            case AnimationType.Appearance:
                _rectTransform.DOScale(0.0f, 0.0f);
                _rectTransform.DOScale(1.0f, _duration).SetEase(_curveEase);
                break;
        }
    }
}
