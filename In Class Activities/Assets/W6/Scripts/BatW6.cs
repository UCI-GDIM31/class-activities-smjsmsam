using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private bool _isChasing;
    [SerializeField] private int _speed;
    public Vector3 catPosition;

    // private void Start()
    // {
    //     _isChasing = true;
    // }

    private void Update()
    {
        if (_isChasing)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                catPosition, _speed * Time.deltaTime);
        }
    }

    public void StopChasing()
    {
        _isChasing = false;
    }

    public void StartChasing()
    {
        _isChasing = true;
    }

}
