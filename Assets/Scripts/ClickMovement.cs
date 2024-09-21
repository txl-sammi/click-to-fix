using UnityEngine;

public class ClickMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    public Sprite upSprite;
    public Sprite downSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;

    private SpriteRenderer spriteRenderer;
    private Vector2 movement;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Get input from the player
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Call the movement function
        MoveCharacter();
        ChangeSpriteDirection();
    }

    void MoveCharacter()
    {
        transform.Translate(movement.normalized * moveSpeed * Time.deltaTime);
    }

    void ChangeSpriteDirection()
    {
        if (movement.y > 0)
        {
            spriteRenderer.sprite = upSprite;
        }
        else if (movement.y < 0)
        {
            spriteRenderer.sprite = downSprite;
        }
        else if (movement.x < 0)
        {
            spriteRenderer.sprite = leftSprite;
        }
        else if (movement.x > 0)
        {
            spriteRenderer.sprite = rightSprite;
        }
    }
}
