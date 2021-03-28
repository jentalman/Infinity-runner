using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField] private Image _healthBarFiller;
    [SerializeField] private Health _healthChanged;
    [SerializeField] private float _duration;

    private void OnEnable()
    {
        _healthChanged.OnPlayerHealthChangedEvent += SetValue;
    }

    private void OnDisable()
    {
        _healthChanged.OnPlayerHealthChangedEvent -= SetValue;
    }

    private void SetValue (float currentHealthNormalized)
    {
        StartCoroutine(FillChange(_healthBarFiller.fillAmount, currentHealthNormalized, _duration));
    }

    private IEnumerator FillChange(float startValue, float endValue, float duration)
    {
        float elapsed = 0;

        while (elapsed < duration)
        {
            _healthBarFiller.fillAmount = Mathf.MoveTowards(startValue, endValue, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        _healthBarFiller.fillAmount = endValue;
    }
}
