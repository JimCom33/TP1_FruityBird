using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsDetect : MonoBehaviour
{
    //public int fruitIndex;
    //public int colorIndex;
    public string correctFruitTag;
    [SerializeField] AudioSource rightBoxSound;
    [SerializeField] AudioSource wrongBoxSound;



    private void OnTriggerEnter2D(Collider2D other)
    {
        string fruitName = other.gameObject.name.Replace("(Clone)", "").Trim();

        if (fruitName == correctFruitTag)
        {
            FindAnyObjectByType<Score>().AddScore(1);
            rightBoxSound.Play();
        }
        else
        {
            Debug.Log("Wrong fruit");
            wrongBoxSound.Play();
        }

        //Fruits fruits = FindAnyObjectByType<Fruits>();
        //PointsDetect pointsDetect = FindAnyObjectByType<PointsDetect>();
        //if (fruits.fruitIndex == pointsDetect.colorIndex)
        //{
            
        //    FindAnyObjectByType<Score>().AddScore(1);

        //    return;
        //}
        //Fruits fruits = FindAnyObjectByType<Fruits>();

        //FindAnyObjectByType<Score>().AddScore(1);


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
