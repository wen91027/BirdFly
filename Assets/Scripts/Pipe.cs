// 繼承：可以享有繼承類別的成員
public class Pipe : Ground
{
    
     float minY, maxY;
     float speedY = 0.05f;

    private void Start()
    {
        // gmaeObject 指的是此類別的遊戲物件
        // 刪除(物件，延遲時間)
        // Destroy(gameObject, 2f);
        maxY = gameObject.transform.position.y + 0.7f;
        minY = gameObject.transform.position.y - 0.7f;
    }

    void FixedUpdate()
    {
        if (gameObject.transform.position.y>maxY|| gameObject.transform.position.y < minY)
        {
            speedY = -speedY;
        }
        gameObject.transform.Translate(0, speedY,0);
    }

    // 掛此類別的物件需要有元件：Mesh Renderer
    // 在攝影機畫面外的時候會執行一次
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 1f);
    }

    // 在攝影機畫面內的時候會執行一次
    private void OnBecameVisible()
    {
        
    }
}
