using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKeyText : MonoBehaviour
{
    [SerializeField, Header("Объект отображения")] private Bag bag;
    [SerializeField, Header("Интерфейс отображения")] private Text text;

    private void Start()
    {
        bag.changeAmountKeys.AddListener(OnChangeHitPoints);            // Подписаться на событие
    }

    private void OnDestroy()
    {
        bag.changeAmountKeys.RemoveListener(OnChangeHitPoints);         // Отписаться от события
    }

    private void OnChangeHitPoints()
    {
        text.text = bag.GetAmountKeys().ToString();
    }
}
