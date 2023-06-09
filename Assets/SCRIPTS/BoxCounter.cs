using UnityEngine;

public class BoxCounter : MonoBehaviour
{
    private int boxCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            // Increment the box count when a box enters the trigger
            boxCount++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            // Decrement the box count when a box exits the trigger
            boxCount--;
        }
    }

    // You can access the boxCount variable from other scripts if needed
    public int GetBoxCount()
    {
        return boxCount;
    }
}
