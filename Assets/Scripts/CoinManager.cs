using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int _numberOfCoinsInLevel;
    
    public void AddOne()
    {
        _numberOfCoinsInLevel += 1;
    }
}
