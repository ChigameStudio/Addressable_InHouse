using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private AddressableObject<GameObject> obj_;
    // Start is called before the first frame update
    void Start()
    {
        obj_ = AddressableCore.CreateAddressable<GameObject>("Assets/Project/AppData/Cube.prefab");
        
    }

    // Update is called once per frame
    void Update()
    {
        obj_.LoadStart();
        obj_.Instance();
        if (obj_.IsSetUp == true)
        {
            Debug.Log(obj_.GetObject.gameObject);
        }
        obj_.Release();
    }
}
