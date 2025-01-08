using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    [SerializeField]
    private Vector2 movementSpeed;

    private Vector2 offset;

    private Material material;

    void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = movementSpeed * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
