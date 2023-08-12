using UnityEngine;
using UnityEngine.UI;

public class UIHealthImage : MonoBehaviour
{
    [SerializeField, Header("Объект отображения")] private Destructible destructible;
    [SerializeField, Header("Интерфейс отображения")] private Image image;

    private void Start()
    {
        destructible.changeHitPoints.AddListener(OnChangeHitPoints);            // Подписаться на событие
    }

    private void OnDestroy()
    {
        destructible.changeHitPoints.RemoveListener(OnChangeHitPoints);         // Отписаться от события
    }

    private void OnChangeHitPoints()
    {
        image.fillAmount = destructible.GetNormalizeHitPoints();
    }
}
