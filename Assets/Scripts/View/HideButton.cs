using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �������� � ���������� ������ �� ������� ��������
/// </summary>
public class HideButton : MonoBehaviour
{
    [SerializeField] private RectTransform panelTransform;
    [SerializeField] private float offset;
    
    private Button hideButton;
    private bool isPanelHided;

    void Start()
    {
        isPanelHided = false;

        hideButton = GetComponent<Button>();
        hideButton.onClick.AddListener(HideOrShowPanel);
    }

    /// <summary>
    /// ������ ��� ���������� ������ ��� ������� �� ������
    /// </summary>
    private void HideOrShowPanel()
    {
        isPanelHided = !isPanelHided;

        if (isPanelHided)
            panelTransform.DOAnchorPosX(-offset, 1.0f).SetEase(Ease.OutQuint);
        else
            panelTransform.DOAnchorPosX(offset, 1.0f).SetEase(Ease.OutQuint);
    }
}
