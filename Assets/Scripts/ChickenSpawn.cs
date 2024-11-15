using UnityEngine;

public class ChickenSpawn : MonoBehaviour
{
    [SerializeField] Transform chickenPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(chickenPrefab, this.gameObject.transform.position, Quaternion.identity);
        }
    }

}