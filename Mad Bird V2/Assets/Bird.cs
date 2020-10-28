using UnityEngine;

public class Bird : MonoBehaviour
{
    Vector3 _initialPosition;

    private void Awake()
    {
        _initialPosition = transform.position;
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        Vector2 directionToInitialPosition = _initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition);
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
