using TMPro;

namespace AnnulusGames.TweenPlayables
{
    public class TweenTextMeshProUGUIMixerBehaviour : TweenAnimationMixerBehaviour<TextMeshProUGUI, TweenTextMeshProUGUIBehaviour>
    {
        private ColorValueMixer colorMixer = new ColorValueMixer();
        private FloatValueMixer fontSizeMixer = new FloatValueMixer();
        private FloatValueMixer characterSpacingMixer = new FloatValueMixer();
        private FloatValueMixer wordSpacingMixer = new FloatValueMixer();
        private FloatValueMixer lineSpacingMixer = new FloatValueMixer();
        private FloatValueMixer paragraphSpacingMixer = new FloatValueMixer();
        private VertexGradientValueMixer colorGradientMixer = new VertexGradientValueMixer();

        public override void Blend(TweenTextMeshProUGUIBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.active)
            {
                colorMixer.Blend(behaviour.color.Evaluate(progress), weight);
            }
            if (behaviour.fontSize.active)
            {
                fontSizeMixer.Blend(behaviour.fontSize.Evaluate(progress), weight);
            }
            if (behaviour.characterSpacing.active)
            {
                characterSpacingMixer.Blend(behaviour.characterSpacing.Evaluate(progress), weight);
            }
            if (behaviour.wordSpacing.active)
            {
                wordSpacingMixer.Blend(behaviour.wordSpacing.Evaluate(progress), weight);
            }
            if (behaviour.lineSpacing.active)
            {
                lineSpacingMixer.Blend(behaviour.lineSpacing.Evaluate(progress), weight);
            }
            if (behaviour.paragraphSpacing.active)
            {
                paragraphSpacingMixer.Blend(behaviour.paragraphSpacing.Evaluate(progress), weight);
            }
            if (behaviour.colorGradient.active)
            {
                colorGradientMixer.Blend(behaviour.colorGradient.Evaluate(progress), weight);
            }
        }

        public override void Apply(TextMeshProUGUI binding)
        {
            if (colorMixer.ValueCount > 0)
            {
                binding.color = colorMixer.Value;
            }
            if (fontSizeMixer.ValueCount > 0)
            {
                binding.fontSize = fontSizeMixer.Value;
            }
            if (characterSpacingMixer.ValueCount > 0)
            {
                binding.characterSpacing = characterSpacingMixer.Value;
            }
            if (wordSpacingMixer.ValueCount > 0)
            {
                binding.wordSpacing = wordSpacingMixer.Value;
            }
            if (lineSpacingMixer.ValueCount > 0)
            {
                binding.lineSpacing = lineSpacingMixer.Value;
            }
            if (paragraphSpacingMixer.ValueCount > 0)
            {
                binding.paragraphSpacing = paragraphSpacingMixer.Value;
            }
            if (colorGradientMixer.ValueCount > 0)
            {
                binding.colorGradient = colorGradientMixer.Value;
            }

            colorMixer.Clear();
            fontSizeMixer.Clear();
            characterSpacingMixer.Clear();
            wordSpacingMixer.Clear();
            lineSpacingMixer.Clear();
            paragraphSpacingMixer.Clear();
            colorGradientMixer.Clear();
        }
    }
}