using DG.Tweening;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private Vector3 _rotationValue = new Vector3(0, 180, 0);
    [SerializeField] private int _loopCount = -1;

    private void Start() => transform.DORotate(_rotationValue, _duration).SetLoops(_loopCount, LoopType.Incremental)
        .SetEase(Ease.Linear);
}