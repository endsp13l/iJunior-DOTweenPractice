using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextAnimator : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private string _targetText = "Аквадискотека";
    [SerializeField] private int _loopCount = -1;

    private Text _text;

    private void Awake() => _text = GetComponent<Text>();

    private void Start() 
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_targetText, _duration));
        sequence.Append(_text.DOText(_targetText, _duration, true, ScrambleMode.All));
        sequence.Append(_text.DOText(_targetText, _duration).SetRelative());
        sequence.SetLoops(_loopCount, LoopType.Restart).Play();
    }
}