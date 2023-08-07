using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRoration : MonoBehaviour
{
    [SerializeField] float _rotatationSpeed;
   

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _rotatationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
     {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
        
     }
}
