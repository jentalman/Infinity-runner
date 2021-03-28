using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    [SerializeField] private TMP_Text _text;

    public int _score;

    private void OnEnable()
    {
        foreach (var i in spawner.Pool)
        {
            i.GetComponent<Health>().ChangeScore += AddScore;
        }
    }

    private void OnDisable()
    {
        foreach (var i in spawner.Pool)
        {
            if (i)
                i.GetComponent<Health>().ChangeScore -= AddScore;
        }
    }

    private void AddScore()
    {
        _score++;
        _text.text = $"Score: " + _score;
        Debug.Log(_score);
    }
}
