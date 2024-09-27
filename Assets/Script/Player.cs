using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;

    public float xMin = -4f;
    public float xMax = 4.2f;
    public float yMin = -4f;
    public float yMax = 4.2f;

    public GameObject[] prefabs;
    [SerializeField] Transform spawnOffset;

    private GameObject currentFruit;
    bool IsHoldingFruit;

    
    // Start is called before the first frame update
    void Start()
    {
        GrabFruit();
    }

    private void GrabFruit()
    {
        
        IsHoldingFruit = true;
        GameObject randomPrefab = prefabs[Random.Range(0, prefabs.Length)];
        randomPrefab.transform.localScale = new Vector3(4f, 4f, 4f);
        currentFruit = Instantiate(randomPrefab, spawnOffset.position, Quaternion.identity, spawnOffset);
        currentFruit.name = randomPrefab.name;


    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 nextPosition = transform.position;

        nextPosition += new Vector3(x, y, 0) * Time.deltaTime * speed;

        nextPosition.x = Mathf.Clamp(nextPosition.x, xMin, xMax);

        nextPosition.y = Mathf.Clamp(nextPosition.y, yMin, yMax);


        transform.position = nextPosition;

        if (Input.GetKeyDown(KeyCode.Space) && IsHoldingFruit)
        {
            IsHoldingFruit = false;
            currentFruit.transform.parent = null;
            currentFruit.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            Invoke("GrabFruit", 1f);
        }
    }

    
}
