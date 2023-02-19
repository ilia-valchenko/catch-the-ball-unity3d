using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private bool isSpaceBarDisabled = false;
    public GameObject dogPrefab;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ToggleSpaceBar", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!this.isSpaceBarDisabled)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }

    public void ToggleSpaceBar()
    {
        this.isSpaceBarDisabled = !this.isSpaceBarDisabled;
    }
}
