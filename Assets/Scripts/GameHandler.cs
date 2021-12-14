using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private BlockMovement[] allPlayerBlocks;

    void Start()
    {
        AllPlayerBlocksArrayUpdate();
    }

    void Update()
    {
        BlockSelection();
    }

    public void BlockDestroyed()
    {
        AllPlayerBlocksArrayUpdate();
        ActiveBlockPlusOne();
    }

    public void BlockSpawned()
    {
        AllPlayerBlocksArrayUpdate();
        ActiveBlockPlusOne();
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("Game Over");
    }

    private void BlockSelection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ActiveBlockPlusOne();
        }
        if (Input.GetMouseButtonDown(1))
        {
            ActiveBlockMinusOne();
        }
    }

    private void AllPlayerBlocksArrayUpdate()
    {
        allPlayerBlocks = FindObjectsOfType<BlockMovement>();
    }

    private void ActiveBlockPlusOne()
    {
        AllPlayerBlocksArrayUpdate();

        for (int i = 0; i < allPlayerBlocks.Length; i++)
        {
            if (allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool)
            {
                allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool = false;

                if (i < allPlayerBlocks.Length - 1)
                {
                    allPlayerBlocks[i + 1].GetComponent<BlockMovement>().isActiveBool = true;
                    break;
                }
                else
                {
                    allPlayerBlocks[0].GetComponent<BlockMovement>().isActiveBool = true;
                    break;
                }
            }
        }
    }

    private void ActiveBlockMinusOne()
    {
        AllPlayerBlocksArrayUpdate();

        for (int i = 0; i < allPlayerBlocks.Length; i++)
        {
            if (allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool)
            {
                allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool = false;

                if (i >= 1)
                {
                    allPlayerBlocks[i - 1].GetComponent<BlockMovement>().isActiveBool = true;
                    break;
                }
                else
                {
                    allPlayerBlocks[allPlayerBlocks.Length - 1].GetComponent<BlockMovement>().isActiveBool = true;
                    break;
                }
            }
        }
    }
}
