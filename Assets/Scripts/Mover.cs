using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward * _movingSpeed * Time.deltaTime, Space.Self);
    }
}
