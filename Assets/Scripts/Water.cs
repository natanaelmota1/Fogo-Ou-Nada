using UnityEngine;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 movement = new Vector3(0f, 0.01f, 0f);
            transform.position += movement * Time.deltaTime * 50;
        }
    }
}
