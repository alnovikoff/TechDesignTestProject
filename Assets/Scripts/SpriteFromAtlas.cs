using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SpriteFromAtlas : MonoBehaviour
{
    [SerializeField] SpriteAtlas atlas;
    [SerializeField] string spriteName;

    void Start()
    {
        if (atlas == null)
        {
            Debug.LogError("no sprite atlas", this);
            return;
        }

        Sprite sprite = atlas.GetSprite(spriteName);
        if (sprite == null)
        {
            Debug.LogError($"sprite '{spriteName}' not found in atlas", this);
            return;
        }

        Image imageComponent = GetComponent<Image>();
        SpriteRenderer spriteRendererComponent = GetComponent<SpriteRenderer>();
        ParticleSystem particleSystem = GetComponent<ParticleSystem>();
        if (imageComponent != null)
        {
            imageComponent.sprite = sprite;
            Debug.Log($"assigned sprite '{spriteName}' to ui Image");
        }
        else if (spriteRendererComponent != null)
        {
            spriteRendererComponent.sprite = sprite;
            Debug.Log($"assigned sprite '{spriteName}' to sprite renderer");
        }
        else if (particleSystem != null)
        {
            AssignSpriteToParticleSystem(particleSystem, sprite);
            Debug.Log($"assigned sprite '{spriteName}' to particle system");
        }
    }

    void AssignSpriteToParticleSystem(ParticleSystem ps, Sprite sprite)
    {
        var textureSheetAnimation = ps.textureSheetAnimation;

        if (textureSheetAnimation.enabled == false)
        {
            textureSheetAnimation.enabled = true;
        }

        textureSheetAnimation.mode = ParticleSystemAnimationMode.Sprites;
        textureSheetAnimation.AddSprite(sprite);
    }
}
