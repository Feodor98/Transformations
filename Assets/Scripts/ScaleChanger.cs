using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private float _scaleIncrement;
    [SerializeField] private float _maxScalingTime;

    private float _currentScalingTime;
    private Vector3 _startScale;

    private void Start()
    {
        _startScale = transform.localScale;
        _currentScalingTime = _maxScalingTime;
    }

    private void Update()
    {
        if (_currentScalingTime > 0)
        {
            transform.localScale += new Vector3(_scaleIncrement, _scaleIncrement, _scaleIncrement) * Time.deltaTime;
            _currentScalingTime -= Time.deltaTime;
        }
        else
        {
            transform.localScale = _startScale;
            _currentScalingTime = _maxScalingTime;
        }
    }
}
