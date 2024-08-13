using UnityEngine;

public abstract class Looper : MonoBehaviour
{
    [SerializeField] protected float _duration = 2f;
    [SerializeField] protected int _loopCount = -1;
}
