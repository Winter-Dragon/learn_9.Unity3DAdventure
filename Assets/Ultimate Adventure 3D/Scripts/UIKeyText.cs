using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKeyText : MonoBehaviour
{
    [SerializeField, Header("������ �����������")] private Bag bag;
    [SerializeField, Header("��������� �����������")] private Text text;

    private void Start()
    {
        bag.changeAmountKeys.AddListener(OnChangeHitPoints);            // ����������� �� �������
    }

    private void OnDestroy()
    {
        bag.changeAmountKeys.RemoveListener(OnChangeHitPoints);         // ���������� �� �������
    }

    private void OnChangeHitPoints()
    {
        text.text = bag.GetAmountKeys().ToString();
    }
}
