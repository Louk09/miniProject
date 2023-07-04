using UnityEngine;

public class NPC : MonoBehaviour
{
    public float speed = 5f; // Speed at which the NPC moves

    private void Update()
    {
        // Move the NPC forward along its forward (blue) axis
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

