using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlyweightExample : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Image> UIImages = new List<Image>();
    TextureFactory textureFactory;
    SpriteFactory spriteFactory;
    private int index = 0;
    void Start()
    {
        textureFactory = new TextureFactory();
        spriteFactory = new SpriteFactory();
        GameObject myObject1 = new GameObject();
        myObject1.AddComponent<MeshRenderer>();
        myObject1.GetComponent<MeshRenderer>().material.mainTexture = textureFactory.GetTexture("1");
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UIImages[index++ % UIImages.Count].sprite = spriteFactory.GetSprite("unsplash2");
        }
    }
}
