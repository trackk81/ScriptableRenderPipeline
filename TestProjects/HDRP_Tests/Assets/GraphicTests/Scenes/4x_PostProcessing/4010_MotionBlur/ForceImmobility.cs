using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceImmobility : MonoBehaviour
{
    Vector3 m_originalPos;
    Quaternion m_originalRot;

    public bool blockPosition = true;
    public bool blockRotation = false;

    // Start is called before the first frame update
    void Start()
    {
        m_originalPos = this.transform.position;
        m_originalRot = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(blockPosition)
            this.transform.position = m_originalPos;

        if (blockRotation)
            this.transform.rotation = m_originalRot;

    }
}
