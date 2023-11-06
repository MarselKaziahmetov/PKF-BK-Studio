using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Скрывает и показывает Панель со списком объектов
/// </summary>
public class HideButton : MonoBehaviour
{
    [SerializeField] private RectTransform panelTransform;
    
    private Button hideButton;
    private bool isPanelHided;

    void Start()
    {
        isPanelHided = false;

        hideButton = GetComponent<Button>();
        hideButton.onClick.AddListener(HideOrShowPanel);
    }

    private void HideOrShowPanel()
    {
        isPanelHided = !isPanelHided;

        if (isPanelHided)
            panelTransform.DOAnchorPosX(-200f, 1.0f).SetEase(Ease.OutQuint);
        else
            panelTransform.DOAnchorPosX(200f, 1.0f).SetEase(Ease.OutQuint);
    }
}
