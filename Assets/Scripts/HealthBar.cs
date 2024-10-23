using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    private RectTransform bar;
    private Image barImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bar = GetComponent<RectTransform>();
        barImage = GetComponent<Image>();
        if (Health.totalHeath < 0.3f)
        {
            barImage.color = Color.red;
        }
        SetSize(Health.totalHeath);
    }

    public void Damage(float damage)
    {
        if((Health.totalHeath -= damage) >= 0f)
        {
            Health.totalHeath -= damage;
        }
        else
        {
            Health.totalHeath = 0f;
        }

        if(Health.totalHeath < 0.3f)
        {
            barImage.color = Color.red;
        }

        SetSize(Health.totalHeath);
    }

    public void SetSize(float size)
    {
        bar.localScale = new Vector3(size, 1f);
    }
}
