using UnityEngine;

public class Exititem : MonoBehaviour
{
    public string ItemName;
    public bool isActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            //Destroy(gameObject);

            gameObject.SetActive(false);
            isActivate = true;
            GameManger.Instance.GetKey();
        }
    }
}
