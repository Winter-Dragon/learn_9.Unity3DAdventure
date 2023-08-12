using UnityEngine;
using UnityEngine.UI;

public class UIHealthImage : MonoBehaviour
{
    [SerializeField, Header("������ �����������")] private Destructible destructible;
    [SerializeField, Header("��������� �����������")] private Image image;

    private void Start()
    {
        destructible.changeHitPoints.AddListener(OnChangeHitPoints);            // ����������� �� �������
    }

    private void OnDestroy()
    {
        destructible.changeHitPoints.RemoveListener(OnChangeHitPoints);         // ���������� �� �������
    }

    private void OnChangeHitPoints()
    {
        image.fillAmount = destructible.GetNormalizeHitPoints();
    }
}
