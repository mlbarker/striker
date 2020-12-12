using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunglasses : MonoBehaviour
{
    #region Serialize Fields

    [SerializeField]
    private float _accuracyDrop = -0.7f;

    #endregion

    #region Public Properties

    public float AccuracyDrop
    {
        get => _accuracyDrop;
        private set => _accuracyDrop = value;
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
